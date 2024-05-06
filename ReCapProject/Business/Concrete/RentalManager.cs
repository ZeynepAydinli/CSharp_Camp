using Business.Abstract;
using Business.Constants;
using Core.Utilities.Result;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete;

public class RentalManager : IRentalService
{
    IRentalDal _rentalDal;

    public RentalManager(IRentalDal rentalDal)
    {
        _rentalDal = rentalDal;
    }
    public IResult Add(Rental rental)
    {
        if (rental.ReturnDate == null)
        {
            return new ErrorResult(Messages.ReturnDateNull);
        }

        _rentalDal.Add(rental);

        return new SuccessResult();
    }

    public IResult Delete(Rental rental)
    {
        throw new NotImplementedException();
    }

    public IDataResult<List<Rental>> GetAll()
    {
        return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
    }

    public IDataResult<List<Rental>> GetRentalsByCompanyId(int id)
    {
        return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(p => p.CompanyID == id));
    }

    public IDataResult<List<Rental>> GetRentalsByUserId(int id)
    {
        return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(p => p.UserID == id));
    }

    public IDataResult<List<Rental>> GetUserById(int id)
    {
        return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(p => p.Id == id));
    }

    public IResult Update(Rental rental)
    {
        throw new NotImplementedException();
    }
}
