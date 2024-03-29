﻿using Roguegame.Repository;
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
            RandomEnemy(out name, out weapon);
            health = RandomEnemyHealth(name);
            return (name, health, weapon);
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
            enemyGeneratedCount++;
            KeyValuePair<string, string> enemy;
            if (enemyGeneratedCount < 5)
            {
                enemy = Enemies.returnEnemyInfo(random.Next(1, 2));
            }
            else if (enemyGeneratedCount >= 5 && enemyGeneratedCount < 10)
            {
                enemy = Enemies.returnEnemyInfo(random.Next(1, 4));
            }
            else
            {
                int listCount = enemyList.Count();
                enemy = Enemies.returnEnemyInfo(random.Next(1, listCount));
            }
            name = Enemies.returnEnemyName(enemy.Key);
            weapon = enemy.Value;
            return (name, weapon);
        }
        public static int RandomHeal()
        {
            return random.Next(1, 11);
        }
        public static int RandomDamage(int maxAttack)
        {
            return (random.Next(1, maxAttack+1));
        }
        public static bool RandomWeaponDrop()
        {
            int randomNumber = random.Next(100);

            if (randomNumber < 33)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
