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
            MyList<int> j = new MyList<int>(5, 1, 2, 3, 4, 5);
            Console.WriteLine("My list after creating:");
            for (int i = 0; i < j.Size; i++)
            {
                Console.WriteLine(j[i]);
            }
            
            j.Add(6);
            Console.WriteLine("My list after adding new elements:");
            for (int i=0;i<j.Size;i++)
            {
                Console.WriteLine(j[i]);
            }
            Console.WriteLine("Size of my list after operations="+j.Size);
            Console.ReadKey();
        }
    }
}
