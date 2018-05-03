using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class MyList<T> where T:IComparable<T>
    {
        public T[] myList;
        public int Count { get; private set; }

        public MyList()
        {
            Count = 0;
            myList = new T[] { };
        }

        public MyList(params T[] input)
        {
            Count = input.Count();
            myList = input;
        }

        public int IndexOf(T input) //index of first entrance
        {
            for(int i=0;i<Count;i++)
            {
                if (input.CompareTo(myList[i])==0) return i;
            }
            return -1;
        }

        public void RemoveAt(int index)// Remove element with index 'index'
        {
            int temp = index;
            for(int i=temp;i<Count-1;i++)
            {
                myList[i] = myList[i + 1];
            }
            Array.Resize(ref myList, --Count);
        }

        public void Remove(T input)//Removing elements == input
        {
            for(int i=0;i<Count;i++)
            {
                if (input.CompareTo(myList[i]) == 0) RemoveAt(i);
            }
        }

        public void Add(T input)//Add new element
        {
            Array.Resize(ref myList, ++Count);
            myList[Count - 1] = input;

        }

        public void AddRange(ICollection collection)//Add a group of elements
        {
            int size = Count;
            Count += collection.Count;
            Array.Resize(ref myList, Count);
            foreach(T col in collection)
            {
                myList[size++] = col;
            }
        }

        public void Clear()//Clear all
        {
            myList = new T[] { };
            Count = 0;
        }
        

        public IEnumerator<T> GetEnumerator()//for 'foreach'
        {
            return ((IEnumerable<T>)myList).GetEnumerator();
        }
    }
}
