using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class ShinyConsoleLine
    {
        public ShinyConsoleLine()
        {
            string str = "***************";

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(str);

            bool boolColorChange = true;

            while (true)
            {
                Console.SetCursorPosition(3, Console.CursorTop - 1);
                Console.ForegroundColor = boolColorChange ? ConsoleColor.Yellow : ConsoleColor.Green;
                Console.WriteLine("*");
                boolColorChange = !boolColorChange;
                System.Threading.Thread.Sleep(250);
                Console.ForegroundColor = boolColorChange ? ConsoleColor.Yellow : ConsoleColor.Green;
            }
            Console.Read();
        }
    }
}
