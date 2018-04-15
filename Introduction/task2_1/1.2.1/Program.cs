using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            double number = Convert.ToDouble(Console.ReadLine());

            for (int i = 1; i <= 20; i++)
                Console.WriteLine("{0} * {1} = {2}", number, i, i * number);

            Console.ReadLine();
        }
    }
}

