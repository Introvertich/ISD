using System;
using System.Collections.Generic;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> dic = new MyDictionary<int, string>();
            dic.Add(0, "Zero");
            dic.Add(0, "Zero");
            dic.Add(1, "One");
            dic.Add(2, "Two");
            for (int i = 0; i < dic.Length; i++)
                Console.WriteLine(i.ToString() + ' ' + dic[i]);
            Console.ReadKey();
        }
    }
}
