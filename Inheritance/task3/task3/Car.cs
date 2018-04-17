using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Car:Vehicle
    {
        public Car() : base() { }
        public Car(int x,int y, double price, double speed, int release) : base(x, y, price, speed, release) { }
    }
}
