using Business.Abstract;
using Core.Utilities.Result;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete;

public class UserManager : IUserService
{
    IUserDal _userDal;
    public UserManager(IUserDal userDal)
    {
        _userDal = userDal;
    }
    public IResult Add(User user)
    {
        throw new NotImplementedException();
    }

    public IResult Delete(User user)
    {
        throw new NotImplementedException();
    }

    public IDataResult<List<User>> GetAll()
    {
        throw new NotImplementedException();
    }

    public IDataResult<List<User>> GetUserById(int id)
    {
        throw new NotImplementedException();
    }

    public IResult Update(User user)
    {
        throw new NotImplementedException();
    }
}
