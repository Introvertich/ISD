using System;

namespace _1._2._7
{
    class Program
    {
        static void Main(string[] args)
        {
            int feet = 64, goose = 0;

            for(int rabbit = 0; rabbit <= 16; rabbit++)
            {
                feet -= rabbit*4;
                goose = (64 - rabbit*4) / 2;
                Console.WriteLine("Goose = {0} and rabbit = {1}", goose, rabbit);
            }

            Console.ReadLine();
        }
    }
}
