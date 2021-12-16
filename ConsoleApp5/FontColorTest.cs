using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class FontColorTest
    {
        public FontColorTest()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("hello");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("hello");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("hello");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("hello");
        }
    }
}
