using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Ship:Vehicle
    {
        public int NumOfPassengers { get; set; }
        public int HomePort { get; set; }
        public Ship():base()
        {
            NumOfPassengers = 0;
            HomePort = 0;
        }
        public Ship(int x, int y, double price, double speed, int release, int port, int num) : base(x,y,price,speed,release)
        {
            HomePort = port;
            NumOfPassengers = num;
        }
        public override void Show()
        {
            base.Show();
            Console.Write(". Количество пассажиров - "+NumOfPassengers+". Порт приписки - "+HomePort);
        }
    }
}
