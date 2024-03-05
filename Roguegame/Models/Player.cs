using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roguegame.Repository
{
    public class Player : Entity
    {
        public Player(string name, string weapon)
        {
            this.name = name;
            this.maxHealth = 20;
            this.health = maxHealth;
            this.weapon = weapon;
        }
    }
}
