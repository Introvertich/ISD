using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Vehicle
    {
        public Tuple<int,int> Coordinates { get; set; }
        public double Price { get; set; }
        public double Speed { get; set; }
        public int Release { get; set; }

        public virtual void Show()
        {
            Console.Write("Координаты - х: "+Coordinates.Item1+", у: "+Coordinates.Item2+". Цена - "+Price+". Скорость - "+Speed+". Год выпуска - "+Release);
        }

        public Vehicle()
        {
            Coordinates = new Tuple<int, int>(0, 0);
            Price = new double();
            Speed = new double();
            Release = new int();
        }

        public Vehicle(int x, int y, double price, double speed, int release)
        {
            Coordinates = new Tuple<int, int>(x, y);
            Price = price;
            Speed = speed;
            Release = release;
        }
    }
}
