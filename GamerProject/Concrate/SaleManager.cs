using Game_Backend;
using GamerProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamerProject.Concrate
{
    class SaleManager : ISaleManager
    {
        public void Sale(Game game, Gamer gamer)
        {
            Console.WriteLine(game.GameName + " Oyunu " +
                gamer.FirstName.ToUpper() + " " +
                gamer.LastName.ToUpper() + " Adlı Oyuncuya " +
                game.GamePrice + " TL'ye satılmıştır.");
        }

        public void Sale(Game game, Gamer gamer, Campaign campaign)
        {
            Console.WriteLine(game.GameName + " Oyunu " +
                gamer.FirstName.ToUpper() + " " + 
                gamer.LastName.ToUpper() + " Adlı Oyuncuya " + 
                (game.GamePrice - (game.GamePrice * campaign.Discount) / 100) + " TL'ye satılmıştır." +
                "Önceki Fiyat: " + game.GamePrice + "  Kazancınız: " + 
                (game.GamePrice - (game.GamePrice - (game.GamePrice * campaign.Discount) / 100)));
        }
    }
}

       
