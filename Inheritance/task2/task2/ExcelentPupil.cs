using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class ExcelentPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Я отличный ученик, у меня одни пятерки!");
        }

        public override void Read()
        {
            Console.WriteLine("Я отличный ученик, я много читаю!");
        }

        public override void Write()
        {
            Console.WriteLine("Я отличный ученик, я красиво пишу!");
        }

        public override void Relax()
        {
            Console.WriteLine("Я отличный ученик, я не отдыхаю!");
        }
    }
}
