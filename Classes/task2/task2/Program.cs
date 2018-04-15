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
            Console.Write("Enter two sides of rectangle: ");
            double side1 = Convert.ToDouble(Console.ReadLine());
            double side2 = Convert.ToDouble(Console.ReadLine());
            Rectangle rec = new Rectangle(side1, side2);
            Console.WriteLine("Area: {0 }; perimeter: {1}", rec.Area, rec.Perimeter);
            Console.ReadKey();
        }
    }
}
