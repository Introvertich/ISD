using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Pupil firstPupil = new ExcelentPupil();
            Pupil secondPupil = new GoodPupil();
            Pupil thirdPupil = new GoodPupil();
            Pupil fourthPupil = new BadPupil();

            ClassRoom classRoom = new ClassRoom(firstPupil, secondPupil, thirdPupil, fourthPupil);
            
            foreach(Pupil p in classRoom.Pupils)
            {
                p.Study();
                p.Read();
                p.Write();
                p.Relax();
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
