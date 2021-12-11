using System;
using System.Collections.Generic;
using System.Text;

namespace GamerProject
{
    class ValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.DateOfBirth==(new DateTime(2003,5,9)) && gamer.FirstName=="Barış Ahmet"&& gamer.LastName=="Fidan"&&gamer.Id==2235)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
