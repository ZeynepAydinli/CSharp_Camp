using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;

Customer customer1 = new Customer();
customer1.Id = 1;
customer1.NationalityId = "123";
customer1.FirstName = "Burak";
customer1.LastName = "Öztaş";
customer1.DateOfBirthYear = 1997;

Customer customer2 = new Customer();
customer2.Id = 2;
customer2.NationalityId = "123";
customer2.FirstName = "Zeynep";
customer2.LastName = "Aydınlı";
customer2.DateOfBirthYear = 1999;


BaseCustomerManager neroCustomerManager = new NeroCustomerManager();
neroCustomerManager.Save(customer1);

BaseCustomerManager starbucksCustomerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
starbucksCustomerManager.Save(customer2);

Console.ReadLine();
