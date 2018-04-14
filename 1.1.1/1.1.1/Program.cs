using System;

namespace _1._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            double first = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            double second = Convert.ToDouble(Console.ReadLine());

            Console.Write("Greater number is ");
            if (first > second)
                Console.WriteLine(first);
            else
                Console.WriteLine(second);


            Console.ReadLine();
        }
    }
}
