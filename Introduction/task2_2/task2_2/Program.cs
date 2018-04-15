using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            
            int count = 0;
            while (num != 0)
            {
                num /= 10;
                count++;
            }
            Console.WriteLine("Number of digits: " + count);
            Console.ReadKey();
        }
    }
}
