using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract;

public interface IRentalService
{
    IDataResult<List<Rental>> GetAll();
    IDataResult<List<Rental>> GetUserById(int id);
    IDataResult<List<Rental>> GetRentalsByCompanyId(int id);
    IDataResult<List<Rental>> GetRentalsByUserId(int id);
    IResult Add(Rental rental);
    IResult Delete(Rental rental);
    IResult Update(Rental rental);
}
