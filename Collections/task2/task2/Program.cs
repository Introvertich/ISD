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
            MyList<int> l = new MyList<int>(1, 2, 3, 4, 5,4);
            Console.WriteLine("My list after creating and filling: ");
            foreach(int i in l)
            {
                Console.Write(i+"\t");
            }
            l.Remove(4);
            Console.WriteLine("\nMy list after removing all elements = 4: ");

            foreach (int i in l)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine("\nMy list after adding group of elements: ");
            l.AddRange(new List<int>() { 1, 2, 3, 4, 5 });
            foreach (int i in l)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine("\nMy array after clearing and adding new elements: ");
            l.Clear();
            l.Add(6);
            l.AddRange(new List<int>() { 5, 6, 1, 7 });
            foreach (int i in l)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine("\nFirst index of 6: "+l.IndexOf(6));
            Console.ReadLine();
        }
    }
}
