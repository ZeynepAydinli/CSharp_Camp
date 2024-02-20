using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo.Adapters;

public class MernisServiceAdapter : ICustomerCheckService
{
    public bool CheckIfRealPerson(Customer customer)
    {
        KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

        return client.TCKimlikNoDogrulaAsync(
             new TCKimlikNoDogrulaRequest
             (new TCKimlikNoDogrulaRequestBody(
                 Convert.ToInt64(customer.NationalityId),
                 customer.FirstName.ToUpper(),
                 customer.LastName.ToUpper(), 
                 customer.DateOfBirthYear)))
             .Result.Body.TCKimlikNoDogrulaResult;
    }
}
