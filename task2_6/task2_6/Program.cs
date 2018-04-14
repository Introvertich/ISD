using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int [] arrOfRandoms=new int[5];
            int sum=0;double result;
            Console.WriteLine("Случайные числа: ");
            for(int i=0;i<5;i++)
            {
                sum += arrOfRandoms[i] = rnd.Next(-42949671,42949672);
                Console.Write(" "+arrOfRandoms[i]);
            }
            Console.WriteLine("\nИх среднее арифметическое: "+Math.Round((double)sum/5,4));
            Console.ReadKey();

        }
    }
}
