using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Roguegame.Models
{
    internal class Enemy
    {
        string name;
        int health;
        int energy = 10;

        public Enemy (string name, int health) //Constructor
        {
            this.name = name;
            this.health = health;
        }

        public void Heal ()
        {

        }

    }
}
