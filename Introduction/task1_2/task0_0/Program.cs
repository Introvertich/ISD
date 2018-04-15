using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter meow or wuf:");
            string animalReplic = Console.ReadLine();

            int choiceAction = animalReplic.Equals("meow", StringComparison.OrdinalIgnoreCase) ? 1 :
                               animalReplic.Equals("wuf", StringComparison.OrdinalIgnoreCase) ? 2 : 0;

            switch (choiceAction)
            {
                case 1: Console.WriteLine("Please, feed your cat!"); break;
                case 2: Console.WriteLine("Please, feed your dog!"); break;
                default: Console.WriteLine("I dont understand you :("); break;
            }

            Console.ReadKey();
        }
    }
}
