using System;
using System.Collections.Generic;
using System.Text;

namespace GamerProject
{
    class GamerManager : IGamerService
    {
        public void Add(Gamer gamer)
        {
            Console.WriteLine("Oyuncu Eklendi");
        }

        public void Dalete(Gamer gamer)
        {
            Console.WriteLine("Oyuncu Silindi");

        }

        public void UpDate(Gamer gamer)
        {
            Console.WriteLine("Oyuncu Eklendi");

        }
    }
}
