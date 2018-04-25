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
            string str = "Hello world!";
            Console.WriteLine(str.MySubstring(6, 5));
            Console.WriteLine(str.MyIndexOf("world!"));
            Console.WriteLine(str.MyReplace("l", "I"));
            
            Console.ReadKey(); 
        }
    }
}
