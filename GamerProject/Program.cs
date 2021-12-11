using GamerProject.Abstract;
using GamerProject.Concrate;
using GamerProject.Entities;
using System;

namespace GamerProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            GamerManager gamerManager = new GamerManager(new MernisManager());
            gamerManager.Valdation(new Gamer
            {
                DateOfBirth = new DateTime(2003, 5, 9),
                FirstName = "Barış Ahmet",
                LastName = "Fidan",
               NationalityId = "0000000001"//TC KİMLİK NO

            }) ;
            Console.ReadLine();

            Gamer gamer1 = new Gamer();
            gamer1.Id = 1;
            gamer1.NationalityId = "11656188196";
            gamer1.FirstName = "Dinçer";
            gamer1.LastName = "Dinç";
            gamer1.DateOfBirth = new DateTime(2000, 8, 25);


            Game game1 = new Game();
            game1.GameId = 1;
            game1.GameName = "Euro Truck Simulator 2";
            game1.GamePrice = 30;
            game1.GameCategory = "Simülasyon";

            IGameManager gameManager = new GameManager();
            gameManager.Add(game1);

            Game game2 = new Game();
            game2.GameId = 1;
            game2.GameName = "Resident Evil 7"; 
            game2.GamePrice = 90;
            game2.GameCategory = "FPS";

            gameManager.Add(game2);
            

            Campaign campaign1 = new Campaign();
            campaign1.CampaignId = 1;
            campaign1.CampaignName = "Yılbaşı Kampanyası";
            campaign1.Discount = 90;

            Campaign campaign2 = new Campaign();
            campaign2.CampaignId = 1;
            campaign2.CampaignName = "Cadılar Bayramı İndirimi";
            campaign2.Discount = 50;

            ICampaignManager campaignManager = new CampaignManager();

            campaignManager.Add(campaign1);
            campaignManager.Add(campaign2);
            
            Console.ReadLine();
            SaleManager saleManager = new SaleManager();
            Console.WriteLine("----------------");
            Console.ReadLine();
            saleManager.Sale(game2, gamer1, campaign1);//90TL-%90
            Console.ReadLine();
            saleManager.Sale(game2, gamer1, campaign2); //90TL-%50
            //saleManager.Sale(game2, gamer1);

            //campaignManager.Delete(campaign1);
            //gameManager.Delete(game1);
            Console.ReadLine();
           
            



        }
    }
}
