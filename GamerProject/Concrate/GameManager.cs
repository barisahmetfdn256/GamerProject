using GamerProject.Abstract;
using GamerProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GamerProject.Concrate
{
    class GameManager : IGameService
    {
        List<Game> games = new List<Game>();
        public GameManager()
        {

        }
        public void Add(Game game)
        {

            games.Add(game);
            Console.WriteLine(game.GameName + " Adlı Oyun Başarıyla Eklendi.");
        }

        public void Delete(Game game)
        {
            games.Remove(game);
            Console.WriteLine(game.GameName + " Adlı Oyun Başarıyla Silindi.");
        }

        public List<Game> GettAll()
        {
            return games;
            foreach (var game in games)
            {
                Console.WriteLine(game.GameName);
            }
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + " Adlı Oyun Başarıyla Güncellendi.");
        }

        static List<Game> gamefilter(List<Game> games)
        {
            return games.Where(g => g.GamePrice < 100).ToList();
        }
    }
}
