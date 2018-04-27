using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{ 
    enum Colors
    {
        White=1,
        Yellow,
        Red,
        Cyan,
        Blue,
        Green,
        Magenta,
        Gray
    }

    class Program
    {
        static void Main(string[] args)
        {
            string input; int numOfColor;
            Console.WriteLine("Введите строку:");
            input = Console.ReadLine();
            Console.WriteLine("Теперь выберите цвет текста. 1-Белый, 2-Желтый, 3-Красный, 4-Голубо-зеленый, 5-Синий, 6-Зеленый, 7-Пурпурный, 8-Серый");
            numOfColor = Convert.ToInt32(Console.ReadLine());
            if (numOfColor < 1 || numOfColor > 8) { Console.WriteLine("Wrong input!"); }
            else
            {
                Console.WriteLine("Ваша информация: ");
                ForPrint.Print(input, numOfColor);
            }
            Console.ReadKey();
        }
    }
}
