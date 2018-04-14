using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 0 or 1:");
            byte number = Convert.ToByte(Console.ReadLine());

            Console.WriteLine(number > 0 ? "Хорошо" : "Плохо");


            Console.ReadLine();
        }
    }
}

