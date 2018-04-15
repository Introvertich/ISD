using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string correctPass = "root";
            string inputPass = "";
            while(!correctPass.Equals(inputPass))
            {
                Console.Clear();
                Console.Write("Enter password: ");
                inputPass = Console.ReadLine();
            }
            Console.WriteLine("nice!");
            Console.ReadKey();
        }
    }
}
