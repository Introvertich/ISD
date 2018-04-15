using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            bool correctInput = false;
            int bet = 0;
            do
            { 
                try
                {
                    Console.Write("Enter yout bet: ");
                    bet = Convert.ToInt32(Console.ReadLine());
                    correctInput = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    correctInput = true;
                }
            } while (correctInput);

            Console.Clear();
            int cubeValue = rnd.Next(1, 13);
            Console.WriteLine("Throwing cube you get " + cubeValue);
            if(cubeValue <= 5)
            {
                Console.WriteLine("You lose {0} :(", bet);
            }
            else if (cubeValue <= 8)
            {
                Console.WriteLine("You return " + bet);
            }
            else if (cubeValue <= 11)
            {
                Console.WriteLine("You won " + bet * 2);
            }
            else
            {
                Console.WriteLine("JackPot you won " + bet * 10);
            }
            Console.ReadKey();
        }
    }
}
