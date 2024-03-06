using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roguegame.Repository
{
    public static class Weapons
    {
        public static Dictionary<string, int> weaponList = new Dictionary<string, int>();
        
        public static void initList()
        {
            weaponList.Clear();
            weaponList.Add("Fists", 2);
            weaponList.Add("Dagger", 4);
            weaponList.Add("Sword", 5);
            weaponList.Add("Two-handed sword", 7);
            weaponList.Add("Enchanted Battle-axe", 10);
        }
        public static int returnMaxAttack(string name)
        {
            return weaponList[name];
        }
    }
}
