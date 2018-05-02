using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class MyClass<T>
    {
        public static MyClass<T> FactoryMethod()
        {
            return new MyClass<T>();
        }
    }
}
