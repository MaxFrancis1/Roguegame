using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roguegame.Repository
{
    public class Entity
    {
        public string name;
        public int maxHealth;
        public int health;
        public string weapon;
        public int energy = 10;

        public void Heal(int amount)
        {
            if (health + amount >= maxHealth)
            {
                health = maxHealth;
            }
            else
            {
                health += amount;
            }
        }
        public bool Damage(int amount)
        {
            if (health - amount <= 0)
            {
                return false;
            } else
            {
                health -= amount;
                return true;
            }
        }
        public int GetHealth() { return health; }
    }
}
