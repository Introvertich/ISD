using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    class Accauntant
    {
        public bool AskForBonus(Position worker, int hours)
        {
            if ((int)worker < hours)
                return true;
            return false;
        }
    }
}
