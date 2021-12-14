using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine("i={0}", i);
                if (i < 5)
                {
                    break;
                }
            }
            //for (int i = 1; i < 10; i++)
            //{
            //    for (int j = 1; j < 10; j++)
            //    {

            //        Console.Write("{0}*{1}={2} ",i,j,i*j);
            //    }
            //    Console.WriteLine();
            //}
            int height = 12;
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 1; i <= height; i++)
            {
                for (int j = 0; j < height - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i + i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}
