using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Figure
    {
        private Point A;
        private Point B;
        private Point C;
        private Point D;
        private Point E;

        public Figure() { }

        public Figure(Point A, Point B, Point C)
        {
            this.A = A;
            this.B = B;
            this.C = C;
        }
        public Figure(Point A, Point B, Point C, Point D)
        {
            this.A = A;
            this.B = B;
            this.C = C;
            this.D = D;
        }
        public Figure(Point A, Point B, Point C, Point D, Point E)
        {
            this.A = A;
            this.B = B;
            this.C = C;
            this.D = D;
            this.E = E;
        }

        public double LengthSide(Point A, Point B)
        {
            return Math.Sqrt((B.X - A.X) * (B.X - A.X) + (B.Y - A.Y) * (B.Y - A.Y));
        }

        public void PerimeterCalculator()
        {
            if (E != null)
            {
                Console.WriteLine("Perimeter of pentagon = {0}", (LengthSide(A, B) + LengthSide(B, C) + LengthSide(C, A) + LengthSide(D, E) + LengthSide(E, A)));
            }
            else if (D != null)
            {
                Console.WriteLine("Perimeter of quadrilateral = {0}", (LengthSide(A, B) + LengthSide(B, C) + LengthSide(C, D) + LengthSide(D, A)));
            }
            else
                Console.WriteLine("Perimeter of triangle = {0}", (LengthSide(A, B) + LengthSide(B, C) + LengthSide(C, A)));
        }
    }
}
