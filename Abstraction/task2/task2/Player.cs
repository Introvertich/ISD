using System;

namespace task2
{
    class Player : IRecodable, IPlayable
    {
        public void Record()
        {
            Console.WriteLine("Recording audio...");
        }

        public void Play()
        {
            Console.WriteLine("Playing audio...");
        }

        void IPlayable.Pause()
        {
            Console.WriteLine("Playing paused");
        }

        void IPlayable.Stop()
        {
            Console.WriteLine("Playing stoped");
        }

        void IRecodable.Pause()
        {
            Console.WriteLine("Recording paused");
        }

        void IRecodable.Stop()
        {
            Console.WriteLine("Recording stoped");
        }
    }
}
