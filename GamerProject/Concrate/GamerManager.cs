using System;
using System.Collections.Generic;
using System.Text;

namespace GamerProject
{
    class GamerManager : IGamerManager
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }
        List<Gamer> gamer = new List<Gamer>();
        public GamerManager()
        {

        }
            public void Valdation (Gamer gamer)
        {
            if (_userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine("Oyuncu Doğrulandı");
            }
            else
            {
                Console.WriteLine("Doğrulama Başarısız");
            }

        }
        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine("Oyuncu Eklendi");
            }
            else
            {
                Console.WriteLine("Doğrulama Başarısız");
            }
            
        }

        public void Dalete(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine("Oyuncu Silindi");
            }
            else
            {
                Console.WriteLine("Doğrulama Başarısız");
            }

        }

       

       
    }
}
