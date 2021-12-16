using System;
using System.Collections.Generic;

namespace ConsoleApp5
{
    class ChristmasTree
    {
        public int height = 12;
        public bool shine = false;
        public int sleepTime = 150;

        ConsoleColor defaultColor = ConsoleColor.Green;
        ConsoleColor color2 = ConsoleColor.Yellow;

        Random random = new Random();

        public ChristmasTree()
        {

            int lightCount = 6;
            List<int> lightNum = new List<int>();

            while (true)
            {

                lightNum.Clear();
                for (int i = 0; i < lightCount; i++)
                {
                    lightNum.Add(random.Next(height * 2 - 1));
                }

                for (int i = 1; i <= height; i++)
                {
                    for (int j = 0; j < height - i; j++) { Console.Write(" "); }
                    for (int j = 0; j < i + i - 1; j++)
                    {
                        if (lightNum.Contains(j)) { printColorChar("*", color2); }
                        else { Console.Write("*"); }
                    }
                    Console.WriteLine("");
                }

                for (int i = 0; i < height / 3; i++)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    for (int j = 0; j < (height / 2); j++) { Console.Write(" "); }
                    for (int k = 0; k < (height - 1); k++) { Console.Write("|"); }
                    Console.WriteLine();
                }
                Console.ForegroundColor = ConsoleColor.Green;
                System.Threading.Thread.Sleep(sleepTime);               
                Console.Clear();
            }
            Console.ReadKey();
        }

        public static void ClearLastLine()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            Console.Write(new string(' ', Console.BufferWidth));
            Console.SetCursorPosition(0, Console.CursorTop - 1);
        }

        public void changeColor()
        {
            if (shine) { Console.ForegroundColor = defaultColor; shine = !shine; }
            else { Console.ForegroundColor = color2; shine = !shine; }
        }

        public void printColorChar(string str, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write(str);
            Console.ForegroundColor = defaultColor;
        }


    }
}
