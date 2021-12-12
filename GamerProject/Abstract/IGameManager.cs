using GamerProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamerProject.Abstract
{
    interface IGameManager
    {
        void Add(Game game);
        void Delete(Game game);
        void Update(Game game);
        List<Game> GettAll();
    }
}
