using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class GoodPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Я хороший ученик, нормально так учусь.");
        }

        public override void Read()
        {
            Console.WriteLine("Я хороший ученик, читаю достаточно выразительно.");
        }

        public override void Write()
        {
            Console.WriteLine("Я хороший ученик, пишу быстро.");
        }

        public override void Relax()
        {
            Console.WriteLine("Я хороший ученик, но люблю отдохнуть.");
        }
    }
}
