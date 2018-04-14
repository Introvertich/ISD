using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1_9
{
    class Program
    {
        static void Main(string[] args)
        {
            const double euro = 32.1;
            const double dollar = 26;
            double sum;

            while (true)
            {

                Console.WriteLine("Введите \"1\" для выбора гривны, \"2\" для выбора доллара, \"3\" для выбора евро и \"4\" для выхода");
                int input = Convert.ToInt32(Console.ReadLine());
                if (input == 4)
                { break; }

                Console.WriteLine("Введите сумму:");
                sum = Convert.ToDouble(Console.ReadLine()); 
                
                if(input==1)
                {
                    Console.WriteLine("Вы выбрали гривну. "+sum+" гривен это "+Math.Round(sum/dollar,2)+" долларов и "+Math.Round(sum/euro,2)+" евро\n");
                }
                else if (input == 2)
                {
                    Console.WriteLine("Вы выбрали доллар. " + sum + " долларов это " + Math.Round(sum * dollar, 2) + " гривен и " + Math.Round((sum*dollar),2) / euro + " евро\n");
                }
                else if (input == 3)
                {
                    Console.WriteLine("Вы выбрали евро. " + sum + " евро это " + Math.Round(sum * euro,2) + " гривен и " + Math.Round((sum * euro) / dollar,2) + " долларов\n");
                }
                else Console.WriteLine("Некорректный ввод.");
            }
        }
    }
}
