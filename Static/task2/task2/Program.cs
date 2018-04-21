using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 5, 67, 4, 8, 9, 12, 0, 5, 4, 5 ,5,888};
            Console.WriteLine("Массив перед сортировкой:");
            foreach (int a in arr)
            {
                Console.WriteLine(a);
            }
            arr.SortAscending(0,arr.Length-1);
            Console.WriteLine("Массив после сортировки:");
            foreach (int a in arr)
            {
                Console.WriteLine(a);
            }
            Console.ReadKey();
        }
    }
}
