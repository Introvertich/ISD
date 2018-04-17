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
            Point A = new Point(0, 0, "point1");
            Point B = new Point(1, 0, "point2");
            Point C = new Point(1, 1, "point3");
            Point D = new Point(0, 1, "point4");

            Figure figure = new Figure(A, B, C, D);

            figure.PerimeterCalculator();
            
            Console.ReadLine();
        }
    }
}
