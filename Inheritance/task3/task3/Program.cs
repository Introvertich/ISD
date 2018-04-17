using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вы хотите ввести информацию о самолёте(1), машине(2) или корабле(3)");
            int info = Convert.ToInt32(Console.ReadLine());
            if(info==1)
            {
                Console.WriteLine("Введите информацию через знак доллара в следующем порядке:\nКоордината х$координата у$цена$скорость$дата выпуска$высота$количесво пассажиров.");
                string[] inp = Console.ReadLine().Split('$');
                try
                {
                    Plane plane = new Plane(Convert.ToInt32(inp[0]), Convert.ToInt32(inp[1]), Convert.ToDouble(inp[2]), Convert.ToDouble(inp[3]), Convert.ToInt32(inp[4]), Convert.ToDouble(inp[5]), Convert.ToInt32(inp[6]));
                    plane.Show();
                }
                catch(Exception)
                {
                    Console.WriteLine("Информация была введена некорректно!");
                }
            }
            else if (info == 2)
            {
                Console.WriteLine("Введите информацию через знак доллара в следующем порядке:\nКоордината х$координата у$цена$скорость$дата выпуска.");
                string[] inp = Console.ReadLine().Split('$');
                try
                {
                    Car car = new Car(Convert.ToInt32(inp[0]), Convert.ToInt32(inp[1]), Convert.ToDouble(inp[2]), Convert.ToDouble(inp[3]), Convert.ToInt32(inp[4]));
                    car.Show();
                }
                catch(Exception)
                {
                    Console.WriteLine("Информация была введена некорректно!");
                }
            }
            else if (info == 3)
            {
                Console.WriteLine("Введите информацию через знак доллара в следующем порядке:\nКоордината х$координата у$цена$скорость$дата выпуска$порт приписки$количесво пассажиров.");
                string[] inp = Console.ReadLine().Split('$');
                try
                {
                    Ship ship = new Ship(Convert.ToInt32(inp[0]), Convert.ToInt32(inp[1]), Convert.ToDouble(inp[2]), Convert.ToDouble(inp[3]), Convert.ToInt32(inp[4]), Convert.ToInt32(inp[5]), Convert.ToInt32(inp[6]));
                    ship.Show();
                }
                catch(Exception)
                {
                    Console.WriteLine("Информация была введена некорректно!");
                }
            }
            else Console.WriteLine("Вы ввели неверную информацию!");
            Console.ReadKey();
        }
    }
}
