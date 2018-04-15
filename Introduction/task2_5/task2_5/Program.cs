using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter 5 numbers separated by space: ");
            string numbersLine = Console.ReadLine();
            string[] numbers = numbersLine.Split(' ');
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += Int32.Parse(numbers[i]);
            }
            Console.WriteLine("Average: " + (double)sum / numbers.Length);
            Console.ReadKey();
        }
    }
}
