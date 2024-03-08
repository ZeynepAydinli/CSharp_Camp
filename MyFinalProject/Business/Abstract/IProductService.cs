using Entities.Concrete;
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
}
