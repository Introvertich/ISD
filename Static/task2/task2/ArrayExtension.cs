using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    stati class ArrayExtension
    {
        public static void SortAscending(this int[] arr, int first, int last)//quicksort
        {
            if(first<last)
            {
                int middle = arr[(first + last) / 2];
                int i = first, j = last;
                while(i<=j)
                {
                    while (i <= last && arr[i] < middle) ++i;
                    while (j >= first && arr[j] > middle) --j;
                    if(i<=j)
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                        ++i;--j;
                    }
                }
                if (i < last) SortAscending(arr, i, last);
                if (j > first) SortAscending(arr, first, j);

            }
        }
    }
}
