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
        public void Damage(int amount)
        {
            if (health - amount <= 0)
            {
                health = 0;
            } else
            {
                health -= amount;
            }
        }
        public int GetHealth() { return health; }
        public void EquipWeapon(string weaponDrop)
        {
            weapon = weaponDrop;
        }
        public string ReturnInfoAsString()
        {
            return ($"Name: {name} \nHealth: {health} \nWeapon: {weapon}\n");
        }
    }
}
