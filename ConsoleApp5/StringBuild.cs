using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class MakeString
    {
        public MakeString()
        {
            string str = "";
            str += "WWWW\n" + "QQQ";            
            str += "\nAmelia \nHello" ;
            Console.WriteLine(str);
            Console.SetCursorPosition(3,2);
            Console.Write("$");
            Console.ReadLine();
        }
    }
}
