using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClub
{
    class FightEventArgs
    {
        public string Name { get; }
        public int HP { get; }

        public FightEventArgs(string name, int hp)
        {
            Name = name;
            HP = hp;
        }
    }
}
