using System;

namespace _1._1._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter natural number:");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(isPrime(number) ? "Is prime number" : "Is NOT prime number :(");

            Console.ReadLine();
        }

        static bool isPrime(int n)
        {
            if (n == 1)
                return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
    }
}
