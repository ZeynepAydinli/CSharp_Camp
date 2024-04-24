using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract;

public interface IProductService
{
    //List<Product> GetAll(); //Sadece list döndürülür.
    IDataResult<List<Product>> GetAll(); //List, işlem sonucu ve mesaj da döndürülür.
    IDataResult<Product> GetAllByCategoryId(int id);
    IDataResult<List<Product>> GetByUnitPrice(decimal min=0, decimal max=0);
    IDataResult<List<ProductDetailDto>> GetProductDetails();
    IDataResult<Product> GetById(int productId);
    //Tek bir product ürün döndürülür.
    IResult Add(Product product);

    //List<Product> GetAllByCategoryId(int id);
    //List<Product> GetByUnitPrice(decimal min = 0, decimal max = 0);
    //List<ProductDetailDto> GetProductDetails();
    //Product GetById(int productId);

}
