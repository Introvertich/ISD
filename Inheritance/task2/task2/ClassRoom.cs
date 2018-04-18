using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class ClassRoom
    {
        private List<Pupil> pupils = new List<Pupil>();

        public List<Pupil> Pupils
        {
            get { return pupils; }
        }

        public ClassRoom() { }
        public ClassRoom(Pupil firstPupil, Pupil secondPupil)
        {
            Pupils.Add(firstPupil);
            Pupils.Add(secondPupil);
        }
        public ClassRoom(Pupil firstPupil, Pupil secondPupil, Pupil thirdPupil)
        {
            Pupils.Add(firstPupil);
            Pupils.Add(secondPupil);
            Pupils.Add(thirdPupil);
        }
        public ClassRoom(Pupil firstPupil, Pupil secondPupil, Pupil thirdPupil, Pupil fourthPupil)
        {
            Pupils.Add(firstPupil);
            Pupils.Add(secondPupil);
            Pupils.Add(thirdPupil);
            Pupils.Add(fourthPupil);
        }
    }
}
