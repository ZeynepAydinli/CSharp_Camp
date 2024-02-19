using Business.Abstract;
using Entities.Concrete;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Adapters;

public class MernisServiceAdapter : IPersonCheckService
{
    public bool CheckPerson(Person person)
    {
        KPSPublicSoapClient client = new KPSPublicSoapClient(
            KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

        return client.TCKimlikNoDogrulaAsync(
            new TCKimlikNoDogrulaRequest
            (new TCKimlikNoDogrulaRequestBody(
                 Convert.ToInt64(person.NationalIdentity), 
                person.FirstName.ToUpper(), 
                person.LastName.ToUpper(), 
                person.DateOfBirthYear)))
            .Result.Body.TCKimlikNoDogrulaResult;
    }
}
