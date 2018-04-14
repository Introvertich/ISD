using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Служба такси заказала вам программу, которая спрашивает количество километров и
//количество минут простоя, а дальше считает так: первые 5 километров(или до 5 км) 20
//гривен, каждый следующий километр 3 гривны, плюс простой 1 грн за 1 минуту.Программа
//должна посчитать и сказать общую сумму оплаты за поездку.

namespace task1_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string input; string[] temp;
            double sum;
            double kilometres;
            int minutes;
            Console.WriteLine("Введите кол-во километров и кол-во минут простоя через пробел:");
            input = Console.ReadLine();
            temp = input.Split(' '); kilometres = Convert.ToDouble(temp[0]); minutes = Convert.ToInt32(temp[1]);
            if (kilometres <= 5)
                sum = 20 + minutes;
            else sum = 20 + (kilometres - 5) * 3 + minutes;
            Console.WriteLine("Общая сумма оплаты: "+sum);
            Console.ReadKey();
        }
    }
}
