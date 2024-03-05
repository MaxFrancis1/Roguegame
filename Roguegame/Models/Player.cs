using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roguegame.Models
{
    internal class Player
    {
        string name;
        int health = 20;
        int energy = 10;

        public Player (string name) //Constructor
        {
            this.name = name;
        }


    }
}
