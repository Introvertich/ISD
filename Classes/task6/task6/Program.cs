using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Какой сегодня курс валюты? Запишите через пробел доллар к гривне, евро к гривне, рубль к гривне:");
            string[] inp = Console.ReadLine().Split(' '); double[] input=new double[] { }; int counter = 0;
            if (inp != null&&inp.Length==3)
            {
                Converter conv = new Converter(Convert.ToDouble(inp[0]), Convert.ToDouble(inp[1]), Convert.ToDouble(inp[2]));
                Console.WriteLine("Вы ходите конвертировать гривну к какой-то валюте(1) или какую-то валюту к гривне(2)?");
                int decision = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите сумму:");
                double amount = Convert.ToDouble(Console.ReadLine());
                if (decision == 1)
                {
                    Console.WriteLine("Конвертировать к доллару(1), к евро(2), к рублю(3):");
                    int info = Convert.ToInt32(Console.ReadLine());
                    if (info == 1)
                    {
                        Console.WriteLine(conv.Convert(4, amount));
                    }
                    else if (info == 2)
                    {
                        Console.WriteLine(conv.Convert(5, amount));
                    }
                    else if (info == 3)
                    {
                        Console.WriteLine(conv.Convert(6, amount));
                    }
                    else Console.WriteLine("Некорректная информация.");
                }
                else if (decision == 2)
                {
                    Console.WriteLine("Конвертировать доллар к гривне(1), евро(2) или рубль(3):");
                    int info = Convert.ToInt32(Console.ReadLine());
                    if (info == 1)
                    {
                        Console.WriteLine(conv.Convert(1, amount));
                    }
                    else if (info == 2)
                    {
                        Console.WriteLine(conv.Convert(2, amount));
                    }
                    else if (info == 3)
                    {
                        Console.WriteLine(conv.Convert(3, amount));
                    }
                    else Console.WriteLine("Некорректная информация.");
                }
                else Console.WriteLine("Некорректная информация.");
                Console.ReadKey();
            }
         
            else { Console.WriteLine("Некорректное значение."); Environment.Exit(0); }

        }
    }
}
