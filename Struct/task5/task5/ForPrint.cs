using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    static class ForPrint
    {
        public static void Print(string stroka,int color)
        {
            Colors colors=(Colors)color;
            switch(colors)
            {
                case Colors.Blue:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(stroka);
                    break;
                case Colors.Cyan:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(stroka);
                    break;
                case Colors.Green:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(stroka);
                    break;
                case Colors.Gray:
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine(stroka);
                    break;
                case Colors.Magenta:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine(stroka);
                    break;
                case Colors.Red:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(stroka);
                    break;
                case Colors.White:
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(stroka);
                    break;
                case Colors.Yellow:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(stroka);
                    break;







            }
        }
    }
}
