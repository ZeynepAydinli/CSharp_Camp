using Business.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract;

public abstract class BaseSupplierService : ISupplierService
{
    public virtual void GiveMask(Person person)
    {
        Console.WriteLine(person.FirstName + " " + person.LastName + " için maske verildi.");
    }
}
