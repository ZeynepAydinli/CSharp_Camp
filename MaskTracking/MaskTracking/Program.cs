using Business.Abstract;
using Business.Adapters;
using Business.Concrete;
using Entities.Concrete;

Person person1 = new Person();
person1.NationalIdentity = "123";
person1.FirstName = "Zeynep";
person1.LastName = "Aydınlı";
person1.DateOfBirthYear = 1990;

Person person2 = new Person();
person2.NationalIdentity = "123";
person2.FirstName = "Burak";
person2.LastName = "Öztaş";
person2.DateOfBirthYear = 1987;

BaseSupplierService pttManager = new PttManager(new MernisServiceAdapter());
pttManager.GiveMask(person1);
pttManager.GiveMask(person2);

// BaseSupplierService pharmacyManager = new PharmacyManager();
// pharmacyManager.GiveMask(person1);
// pharmacyManager.GiveMask(person2);

Console.ReadLine();


