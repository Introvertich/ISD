using System;

namespace _1._2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int number = Convert.ToInt32(Console.ReadLine());

            int i = 1;
            while (i * i < number)
            {
                Console.WriteLine("{0} * {1} = {2}", i, i, i * i);
                i++;
            }

            Console.ReadLine();
        }
    }
}
