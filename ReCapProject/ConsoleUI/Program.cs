using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

CarManager carManager = new CarManager(new EfCarDal());

var result = carManager.GetCarDetails();
if(result.Success == true)
{
    foreach (var car in result.Data)
    {
        Console.WriteLine(car.CarName + " " + car.BrandName + " " + car.ColorName + " " + car.DailyPrice);
    }
}
else
{
    Console.WriteLine(result.Message);
}


