using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> myList = new MyList<int>( 5, 5, 4, 3, 2, 1 );

            var arr = myList.GetArray();
            
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Элемент {i+1} = {arr[i]};") ;
            }

            Console.ReadLine();
        }
    }
}
