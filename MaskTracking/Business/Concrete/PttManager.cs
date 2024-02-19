using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete;

public class PttManager : BaseSupplierService, IApplicantService
{
    private IPersonCheckService _personCheckService;

    public PttManager(IPersonCheckService personCheckService)
    {
        _personCheckService = personCheckService;
    }

    public void ApplyForMask(Person person)
    {
        throw new NotImplementedException();
    }

    public List<Person> GetList()
    {
        throw new NotImplementedException();
    }

    public override void GiveMask(Person person) 
    {   
        if(_personCheckService.CheckPerson(person))
        {
            base.GiveMask(person);
        }
        else
        {
            Console.WriteLine(person.FirstName + " " + person.LastName + " için maske verilemedi!!!");
        }
    }
}
