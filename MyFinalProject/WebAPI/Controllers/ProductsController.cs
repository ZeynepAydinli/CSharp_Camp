using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController] // c# -> Attribute
public class ProductsController : ControllerBase
{
    //Loosely coupled
    //naming convention
    //IoC Container -> Inversion of Control 
    IProductService _productService;

    public ProductsController(IProductService productService)
    {
        _productService = productService;
    }

    //[HttpGet]
    //public List<Product> Get()
    //{
    //    //Dependency cahin 
    //    //IProductService productService = new ProductManager(new EfProductDal());
    //    var result = _productService.GetAll(); //IoC program.cs içindedir. 
    //    return result.Data;
    //}

    [HttpGet("getall")] //Postman'de api/products/getall yazılır
    public IActionResult GetAll() //**List<Product> yerine IActionResult yazıldı. 
    {
        var result = _productService.GetAll(); //IoC program.cs içindedir. 
        if (result.Success)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }

    [HttpGet("getbyid")] //getbyid ismi verildi. Eğer bu yazılmaz ise sistem hata verir
    public IActionResult GetById(int id) //Postman'de api/products/getbyid?id=1 yazılır
    {
        var result = _productService.GetById(id);
        if (result.Success)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }

    [HttpPost("add")] //Postman'de api/products/add yazılır
    public IActionResult Add(Product product)
    {
        var result = _productService.Add(product);
        if (result.Success)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }



}
