using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class BadPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Что? Какая учеба?");
        }

        public override void Read()
        {
            Console.WriteLine("Я умею читать по слогам.");
        }

        public override void Write()
        {
            Console.WriteLine("Пишу криво, но пишу.");
        }

        public override void Relax()
        {
            Console.WriteLine("Релакс - моё любимое состояние!");
        }
    }
}
