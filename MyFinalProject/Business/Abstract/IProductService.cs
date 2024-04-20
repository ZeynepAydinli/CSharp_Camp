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
    List<Product> GetAll();
    List<Product> GetAllByCategoryId(int id);
    List<Product> GetByUnitPrice(decimal min=0, decimal max=0);
    List<ProductDetailDto> GetProductDetails();
    Product GetById(int productId);
    //Tek bir product ürün döndürülür.
    IResult Add(Product product);
}
