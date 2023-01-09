using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    internal class Program
    {
        // structs
        struct vector2
        {
            public int x;
            public int y;
        }
        static int x; //position
        static int y; //position
        static string playername; //name

        static void Main(string[] args)
        {
            vector2 playerPosition;
            playerPosition.x = 20;
            playerPosition.y = 32;
            Console.WriteLine("PlayerX: " + playerPosition.x + "PlayerY: " + playerPosition.y);
            Console.WriteLine("");
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

        }
    }
}
