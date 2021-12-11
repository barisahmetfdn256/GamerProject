using GamerProject.Abstract;
using GamerProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamerProject.Concrate
{
    class GameManager : IGameManager
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

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + " Adlı Oyun Başarıyla Güncellendi.");
        }
        
    }
}
