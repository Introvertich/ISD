using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Программа загадывает число от 1 до 146. Пользователь пытается его угадать.В случае не
//верного ответа программа дает подсказку «больше» или «меньше»

namespace task2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int myNum = rnd.Next(1, 147);
            int input, counter=0;
            bool found = false;
            Console.WriteLine("Программа загадала число от 1 до 146. Попробуйте его угадать.");
            while(true)
            {
                Console.WriteLine("Введите Ваше предположение:");
                input = Convert.ToInt32(Console.ReadLine());
                counter++;
                if (input == myNum)
                {
                    Console.WriteLine("Ура! Вы нашли правильное значение с "+counter+" раза.");
                    break;
                }
                else if(myNum>input)
                    Console.WriteLine("Ваше число меньше заданного. Попробуйте ещё раз!");
                else Console.WriteLine("Ваше число больше заданного. У Вас всё получится!");
            }
            Console.ReadKey();
        }
    }
}
