using Roguegame.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Roguegame.Services
{
    public static class Initialise
    {
        public static void Init()
        {
            Weapons.initList();
            introduction();
        }
        public static void introduction()
        {
            Console.Write("You awaken in a damp cave, you remember your name is: ");
            string name = Console.ReadLine();

            Console.WriteLine($"That's right, {name}. You start to remember where you are, and your purpose. Kill, kill them all.");
            Console.WriteLine("You make your way outside of the cave and an enemy Goblin appears infront of you, as if you are in a game.");
            Console.WriteLine("You prepare for battle. (Type Attack to start the onslaught)");
            
            RunTime.runGame(name, "Fists");
        }
    }
}
