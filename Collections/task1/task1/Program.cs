using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7 };

            IEnumerable<int> l = GetEvenNumbers(numbers);

            foreach (int i in l)
                Console.WriteLine(i);

            Console.ReadLine();
        }

        static IEnumerable<int> GetEvenNumbers(int[] numbers)
        {
            foreach (int e in numbers)
            {
                if (e % 2 == 0)
                {
                    yield return e;
                }
            }
        }
    }
}
