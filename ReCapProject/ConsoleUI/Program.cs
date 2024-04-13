using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

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
Console.WriteLine("---------------------");
foreach (var carDto in carManager.GetCarDetails())
{
    Console.WriteLine("Car Name: " + carDto.CarName);
    Console.WriteLine("Brand: " + carDto.BrandName);
    Console.WriteLine("Color: " + carDto.ColorName);
    Console.WriteLine("Daily Price: " + carDto.DailyPrice);
    Console.WriteLine("---------------------");
}


