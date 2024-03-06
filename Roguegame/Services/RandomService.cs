using Roguegame.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roguegame.Services
{
    public class RandomService
    {
        static Random random = new Random();
        private static Dictionary<string, string> enemyList = new Dictionary<string, string>();
        private static int enemyGeneratedCount = 0;
        public static (string name, int health,  string weapon) NewEnemy(out string name, out int health, out string weapon)
        {
            name = null;
            health = 0;
            weapon = null;
            enemyGeneratedCount++;
            RandomEnemy(out name, out weapon);
            return (name, RandomEnemyHealth(name), weapon);
        }
        private static int RandomEnemyHealth(string name)
        {
            switch (name)
            {
                case "Goblin":
                    return random.Next(6, 11);
                case "Demon":
                    return random.Next(10, 20);
                default:
                    return 1;
            }
        }
        private static (string name, string weapon) RandomEnemy(out string name, out string weapon)
        {
            name = null;
            weapon = null;
            if (enemyGeneratedCount < 5)
            {
                KeyValuePair<string, string> enemy = Enemies.returnEnemyInfo(random.Next(1,3));
                return (enemy.Key, enemy.Value);
            }
            else
            {
                KeyValuePair<string, string> enemy = Enemies.returnEnemyInfo(random.Next(0, enemyList.Count));
                return (enemy.Key, enemy.Value);
            }
        }
        public static int RandomHeal()
        {
            return random.Next(1, 11);
        }
        public static int RandomDamage(int maxAttack)
        {
            return (random.Next(1, maxAttack));
        }
    }
}
