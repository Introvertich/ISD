using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    static class ArrayExtension
    {
        public static T[] GetArray<T>(this IEnumerable<T> list)
        {
            return list.ToArray();
        }
    }
}
