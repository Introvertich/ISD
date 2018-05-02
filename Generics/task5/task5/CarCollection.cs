using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    class CarCollection<T,U> 
    {
        public Tuple<T, U>[] cars { get; set; }
        public int Size { get; private set; }


        public CarCollection()
        {
            cars = new Tuple<T, U>[] { };
            Size = 0;
        }

        public CarCollection(int size,params Tuple<T,U>[]tuple)
        {
            cars = tuple;
            Size = size;
        }

        public Tuple<T,U> this[int i]
        {
           get { return cars[i]; }
            set { cars[i] = value; }
        }

       public void Add(T carName,U year)
        {
            if (carName.GetType() == typeof(string) && year.GetType() == typeof(int))
            {
                Tuple<T, U>[] temp = new Tuple<T, U>[++Size];
                for(int i=0;i<Size-1;i++)
                {
                    temp[i] = cars[i];
                }
                temp[Size - 1] = new Tuple<T, U>(carName, year);
                cars = temp;
            }


            
        }

        public void DeleteAll()
        {
            Tuple<T, U>[] temp = new Tuple<T, U>[0];
            Size = 0;
            cars = temp;
        }

    }
}
