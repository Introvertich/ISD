using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "изменен";
        }
        static void StructTaker(MyStruct myStruct)
        {
            myStruct.change = "изменена";
        }
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            MyStruct myStruct = new MyStruct();
            myClass.change = "не изменен";
            myStruct.change = "не изменена";
            ClassTaker(myClass);
            StructTaker(myStruct);
            Console.WriteLine("Структура: {0}\nКласс: {1}", myStruct.change, myClass.change);
            Console.ReadKey();
        }
    }
}
