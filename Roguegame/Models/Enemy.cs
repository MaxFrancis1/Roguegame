using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Roguegame.Repository
{
    public class Enemy : Entity
    {
        public int id;
        public Enemy(int id, string name, int health, string weapon)
        {
            this.name = name;
            this.maxHealth = health;
            this.health = maxHealth;
            this.weapon = weapon;
        }
    }
}
