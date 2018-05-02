using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            CarCollection<string, int> car = new CarCollection<string, int>(2, new Tuple<string, int>("heh", 1998), new Tuple<string, int>("mazda", 2000));
            car.Add("BMV", 2017);
            Console.WriteLine("Before deleting:");
            for(int i=0;i<car.Size;i++)
            {
                Console.WriteLine(car[i].Item1+" "+car[i].Item2);
            }
            car.DeleteAll();
            car.Add("Honda", 2014);
            Console.WriteLine("After deleting and adding new element:");
            for (int i = 0; i < car.Size; i++)
            {
                Console.WriteLine(car[i].Item1 + " " + car[i].Item2);
            }
            Console.ReadKey();
        }
    }
}
