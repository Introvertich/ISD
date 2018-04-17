using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Plane:Vehicle
    {
        public double Attitude { get; set; }
        public int NumOfPassengers { get; set; }

        public Plane():base()
        {
            Attitude = 0;
            NumOfPassengers = 0;
        }
        public Plane(int x,int y, double price, double speed, int release, double attitude, int num):base(x,y,price,speed,release)
        {
            Attitude = attitude;
            NumOfPassengers = num;
        }

        public override void Show()
        {
            base.Show();
            Console.Write(". Высота - "+Attitude+". Количество пассажиров - "+NumOfPassengers);
        }
    }
}
