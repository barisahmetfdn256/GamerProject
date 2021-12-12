using GamerProject;
using GamerProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game_Backend
{
    interface ISaleService
    {
        void Sale(Game game, Gamer gamer);

        void Sale(Game game, Gamer gamer, Campaign campaign);
    }
}