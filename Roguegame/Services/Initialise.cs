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
            Console.Write("You awaken in a damp cave, you remember your name is: ");
            Console.Read();
        }
    }
}
