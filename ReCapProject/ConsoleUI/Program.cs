using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

CarManager carManager = new CarManager(new EfCarDal());

foreach (var car in carManager.GetAll())
{
     Console.WriteLine(car.Description);
}
Console.WriteLine("---------------------");
foreach (var car in carManager.GetCarsByBrandId(10))
{
    Console.WriteLine(car.Description);
}
Console.WriteLine("---------------------");
foreach (var car in carManager.GetCarsByColorId(1))
{
    Console.WriteLine(car.Description);
}
Console.WriteLine("---------------------");
foreach (var car in carManager.GetByUnitPrice(700000, 900000))
{
    Console.WriteLine(car.Description);
}

