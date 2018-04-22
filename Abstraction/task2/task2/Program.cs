using System;
using System.Threading;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Player pl = new Player();
            pl.Record();
            Thread.Sleep(2000);
            ((IRecodable)pl).Pause();
            ((IRecodable)pl).Stop();
            pl.Play();
            Thread.Sleep(2000);
            ((IPlayable)pl).Pause();
            ((IPlayable)pl).Stop();
            Console.ReadKey();
        }
    }
}
