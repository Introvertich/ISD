using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task8
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice inv = new Invoice(123456789, "Petr Petrov", "Bober Bobrov", 5678);
            inv.Article = "oak stick";
            inv.Quantity = 789;
            Console.WriteLine(inv.ToString());
            Console.ReadKey();
        }
    }
}
