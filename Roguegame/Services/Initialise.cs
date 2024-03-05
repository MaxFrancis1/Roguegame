using Roguegame.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roguegame.Services
{
    public static class Initialise
    {
        public static void Init()
        {
            Weapons.initList();

            Console.Write("You awaken in a damp cave, you remember your name is: ");
            string name = Console.ReadLine();
            createPlayer(name);
            Console.WriteLine($"That's right, {name}. You start to remember where you are, and your purpose. Kill, kill them all.");
        }
        public static void createPlayer(string playerName)
        {
            Player player = new Player(playerName, "Fists");
        }
    }
}
