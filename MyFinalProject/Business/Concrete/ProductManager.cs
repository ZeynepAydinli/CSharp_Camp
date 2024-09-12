using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete;

public class ProductManager : IProductService
{
    //Product Manager sınıfına kendisinden başka(Product Dal) Dal sınıfı eklenemez. 

    IProductDal _productDal;
    ICategoryService _categoryService;

    public ProductManager(IProductDal productDal, ICategoryService categoryService)
    {
        _productDal = productDal;
        _categoryService = categoryService;
    }

    [ValidationAspect(typeof(ProductValidator))] //Çalışıp okunabilmesi için AutofacBusinessModule sınıfındaki var assembly yazıldı
    public IResult Add(Product product)
    {
        //if (product.ProductName.Length < 2)
        //{
        //    //magic strings
        //    return new ErrorResult(Messages.ProductNameInvalid);
        //}

        //Fluent Validation added

        //ValidationTool.Validate(new ProductValidator(), product); **ValidationTool sınıfı core katmanında

        IResult result = BusinessRules.Run(CheckIfProductNameExists(product.ProductName),
            CheckIfProductCountCategoryCorrect(product.CategoryId),
            CeheckIfCategoryLimitExceded());

        if(result!= null)
        {
            return result;
        }

        _productDal.Add(product);

        return new SuccessResult(Messages.ProductAdded); 
    }

    public IDataResult<List<Product>> GetAll()
    {
       //Business codes
        if (DateTime.Now.Hour == 03)
        {
            return new ErrorDataResult<List<Product>>(Messages.MaintenanceTime);
        }
        return new SuccessDataResult<List<Product>>(_productDal.GetAll(), Messages.ProductsListed);
    }

    public IDataResult<Product> GetAllByCategoryId(int id)
    {
        return new SuccessDataResult<Product>(_productDal.Get(p => p.CategoryId == id));
    }

    public IDataResult<Product> GetById(int productId)
    {
        return new SuccessDataResult<Product>(_productDal.Get(p => p.ProductId == productId));
    }

    public IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max)
    {
        return new SuccessDataResult<List<Product>>(_productDal.GetAll(
            p => p.UnitPrice >= min && p.UnitPrice <= max));
    }

    public IDataResult<List<ProductDetailDto>> GetProductDetails()
    {
        //if (DateTime.Now.Hour == 3)
        //{
        //    return new ErrorDataResult<List<ProductDetailDto>>(Messages.MaintenanceTime);
        //}
        return new SuccessDataResult<List<ProductDetailDto>>(_productDal.GetProductDetails());
    }

    [ValidationAspect(typeof(ProductValidator))]
    public IResult Update(Product product)
    {
        IResult result = BusinessRules.Run(CheckIfProductNameExists(product.ProductName),
            CheckIfProductCountCategoryCorrect(product.CategoryId));

        if (result != null)
        {
            return result;
        }

        _productDal.Update(product);

        return new SuccessResult(Messages.ProductUpdated);
    }

    //Business Rules
    private IResult CheckIfProductCountCategoryCorrect(int categoryId)
    {
        //select count(*) from products where categoryId=1
        var result = _productDal.GetAll(p => p.CategoryId == categoryId).Count;
        if (result > 15)
        {
            return new ErrorResult(Messages.ProductCountOfCategoryError);
        }
        return new SuccessResult();
    }

    private IResult CheckIfProductNameExists(string productName)
    {
        var result = _productDal.GetAll(p => p.ProductName == productName).Any();
        if(result)
        {
            return new ErrorResult(Messages.ProductNameAlreadyExists);
        }
        return new SuccessResult();
    }

    private IResult CeheckIfCategoryLimitExceded()
    {
        var result = _categoryService.GetAll();
        if(result.Data.Count > 15)
        {
            return new ErrorResult(Messages.CategoryLimitExceded);
        }
        return new SuccessResult();
    }

    
}
