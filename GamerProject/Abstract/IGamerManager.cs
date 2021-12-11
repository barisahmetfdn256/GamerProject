using System;
using System.Collections.Generic;
using System.Text;

namespace GamerProject
{
    interface IGamerManager
    {
        void Add(Gamer gamer);
        void UpDate(Gamer gamer);
        void Dalete(Gamer gamer);
    }
}
