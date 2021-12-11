using System;
using System.Collections.Generic;
using System.Text;


namespace GamerProject
{
    
    class MernisManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            MernisDoğrulama.KPSPublicSoapClient client = new MernisDoğrulama.KPSPublicSoapClient(MernisDoğrulama.KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync
                (Convert.ToInt64(gamer.NationalityId),
                gamer.FirstName.ToUpper(),
                gamer.LastName.ToUpper(),
                gamer.DateOfBirth.Year
                ).Result.Body.TCKimlikNoDogrulaResult;
       
        }
    }
}
