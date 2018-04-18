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
            Printer p1 = new Printer();
            Printer p2 = new MyPrinter();
            MyPrinter p3 = new MyPrinter();
            Printer p4 = new Printer(ConsoleColor.DarkRed);
            p1.Print("Printer");
            p2.Print("Printer as MyPrinter");
            p3.Print("MyPrinter");
            p4.Print("Color=DarkRed");
            Console.ReadKey();
        }
    }
}
