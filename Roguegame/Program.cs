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
            Initialise.Init();
            Player player = new Player(name, weapon);

            for (int i; i > 99; i++)
            {
                //Enemy enemy = new Enemy(name, weapon);



                Console.ReadLine();
            }
        }
    }
}
