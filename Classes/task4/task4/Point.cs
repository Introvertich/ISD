using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Point
    {
        private int x;
        private int y;
        private string pointName;

        public int X
        {
            get { return x; }
        }
        public int Y
        {
            get { return y; }
        }
        public string PointName
        {
            get { return pointName; }
        }

        public Point() { }

        public Point(int x, int y, string c)
        {
            this.x = x;
            this.y = y;
            this.pointName = c;
        }
    }
}
