using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roguegame.Repository
{
    internal class Enemies
    {
        public static Dictionary<string, string> enemyList = new Dictionary<string, string>();

        public static void initList()
        {
            enemyList.Clear();
            enemyList.Add("Goblin", "Dagger");
            enemyList.Add("Goblin", "Sword");
            enemyList.Add("Demon", "Two-handed sword");
            enemyList.Add("Demon", "Enchanted Battle-axe");
        }
        public static KeyValuePair<string, string> returnEnemyInfo(int position)
        {
            return enemyList.ElementAt(position);
        }
    }
}
