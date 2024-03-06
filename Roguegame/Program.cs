using Roguegame.Repository;
using Roguegame.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Roguegame
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string name = Initialise.Init();
            List<Enemy> enemies = new List<Enemy>();
            Player player = new Player(name, "Fists");

            
            
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine(i); //dev

                //want to create a while loop and get health so as long as its above 0 the player is able to attack.
                RandomService.NewEnemy(out string eName, out int eHealth, out string eWeapon);
                enemies.Add(new Enemy(i, eName, eHealth, eWeapon));

                Console.WriteLine(enemies[i]);


                Console.ReadLine();
            }
        }
    }
}
