using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> list = new MyList<int>(){ 0, 1, 2, 3, 4, 5, 6};
            foreach (var item in list.ToArray())
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
