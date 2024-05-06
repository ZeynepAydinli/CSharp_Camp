using Business.Abstract;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete;

public class CustomerManager : ICustomerService
{
    ICustomerDal _customerDal;

    public CustomerManager(ICustomerDal customerDal)
    {
        _customerDal = customerDal;
    }
    public IResult Add(Customer customer)
    {
        throw new NotImplementedException();
    }

    public IResult Delete(Customer customer)
    {
        throw new NotImplementedException();
    }

    public IDataResult<List<Customer>> GetAll()
    {
        throw new NotImplementedException();
    }

    public IDataResult<List<Customer>> GetUserById(int id)
    {
        throw new NotImplementedException();
    }

    public IResult Update(Customer customer)
    {
        throw new NotImplementedException();
    }
}
