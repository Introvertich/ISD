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
            var value1 = MyClass<int>.FactoryMethod();
            var value2 = MyClass<string>.FactoryMethod();

            Console.ReadLine();
        }
    }
}
