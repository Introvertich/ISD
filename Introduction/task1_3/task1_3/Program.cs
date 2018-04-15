using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Пользователь вводит номер месяца если месяц 1,2,12 вывести на экран «Зима»; 3,4,5 –
//«Весна»; 6-8 – «Лето»; 9-11 – «Осень». В любом другом случае «На этой планете такого месяца
//нет»

namespace task1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int monthNum;
            Console.WriteLine("Пожалуйста, введите номер месяца:");
            string input = Console.ReadLine();
            bool stringIsNumber = input.Length == input.Where(c => char.IsDigit(c)).Count();
            if (stringIsNumber)
            {
                monthNum = Convert.ToInt32(input);
                if (monthNum == 1 || monthNum == 2 || monthNum == 12)
                    Console.WriteLine("Зима");
                else if (monthNum >= 3 && monthNum <= 5)
                    Console.WriteLine("Весна");
                else if (monthNum >= 6 && monthNum <= 8)
                    Console.WriteLine("Лето");
                else if (monthNum>=9&&monthNum<=11)
                    Console.WriteLine("Осень");
                else Console.WriteLine("На этой планете такого месяца нет");
            }
            else Console.WriteLine("Некорректный ввод");
            Console.ReadKey();
            
        }
    }
}
