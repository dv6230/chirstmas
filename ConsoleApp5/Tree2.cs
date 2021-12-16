using System;

namespace ConsoleApp5
{
    class Tree2
    {
        public Tree2()
        {
            int height = 12;
            string str = "";

            bool isCol = true;
            Random r = new Random();

            Console.ForegroundColor = ConsoleColor.Green;
            ConsoleColor[] colorAry = { 
                ConsoleColor.Red, 
                ConsoleColor.Yellow,
                ConsoleColor.Cyan,
                ConsoleColor.White , 
                ConsoleColor.Magenta , 
                //ConsoleColor.DarkYellow
            };
          

            for (int i = 1; i <= height; i++)
            {
                for (int j = 0; j < height - i; j++) { str += " "; }
                for (int j = 0; j < i + i - 1; j++)
                {
                    str += "*";
                }
                if(i != height) str += "\n";
            }

            Console.WriteLine(str);

            for (int i = 0; i < height / 3; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                for (int j = 0; j < (height / 2); j++) { str += " "; Console.Write(" "); }
                for (int k = 0; k < (height - 1); k++) { str += "|"; Console.Write("|"); }
                Console.WriteLine();
                //str += "\n";
                Console.ForegroundColor = ConsoleColor.DarkGreen;
            }

            while (true)
            {
                shiningLight(3,12);
                shiningLight(5, 9);
                shiningLight(6, 7);
                shiningLight(7,15);
                shiningLight(8, 6);
                shiningLight(9, 16);
                shiningLight(10, 12);
                shiningLight(11, 5);
                shiningLight(11, 18);
                isCol = !isCol;
                Console.SetCursorPosition(0, 12 + height / 3);
                if (isCol) System.Threading.Thread.Sleep(150);
                if (!isCol) System.Threading.Thread.Sleep(300);
            }


            void shiningLight(int lineAt, int charAt)
            {
                Console.ForegroundColor = colorAry[r.Next(0,colorAry.Length)];
                Console.SetCursorPosition(charAt, lineAt - 1);
                Console.Write("o");
                Console.SetCursorPosition(charAt, lineAt - 1);
            }


        }



    }
}
