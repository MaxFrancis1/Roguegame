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
            enemyList.Add("G1", "Dagger");
            enemyList.Add("G2", "Sword");
            enemyList.Add("O1", "Two-handed sword");
            enemyList.Add("D1", "Enchanted Battle-axe");
        }
        public static KeyValuePair<string, string> returnEnemyInfo(int position)
        {
            return enemyList.ElementAt(position);
        }
        public static string returnEnemyName(string key)
        {
            switch (key)
            {
                case "G1": 
                    return "Goblin";
                case "G2":
                    return "Goblin";
                case "O1":
                    return "Orc";
                case "D1":
                    return "Demon";
                default:
                    return "error no enemy found";
            }
        }
    }
}
