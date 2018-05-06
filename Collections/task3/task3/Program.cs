using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> dic = new MyDictionary<int, string>
            {
                { 0, "Zero" },
                { 0, "Zero" },
                { 1, "One" },
                { 2, "Two" }
            };

            dic.RemoveAt(1);

            foreach (var item in dic)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
