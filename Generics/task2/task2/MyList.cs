using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class MyList<T>
    {
        public T[] MyArray;
        public int Size { get; private set; }

        public MyList()
        {
            Size = 0;
            MyArray = new T[] { };
         
        }
        public MyList(int size,params T[] list)
        {
            Size = size;
            MyArray = list;
        }
        public T this[int i]
        {
            get { return MyArray[i]; }
            set {
                if(i<=Size)
                MyArray[i] = value; }
        }

        public void Add(T newElement)
        {
            Size++;
            T[] newMyArray = new T[Size];
            for(int i=0;i<Size-1;i++)
            {
                newMyArray[i] = MyArray[i];
            }
            newMyArray[Size-1] = newElement;
            MyArray = newMyArray;
        }
    }
}
