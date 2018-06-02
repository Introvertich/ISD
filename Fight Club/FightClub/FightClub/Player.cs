using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClub
{
    enum BodyParts
    {
        Head, Body, Legs
    }


    class Player
    {
        public string Name { get; }

        private int hp;
        private BodyParts bloked;
        
        public delegate void FightStateHandler(object sender, FightEventArgs e);
        public event FightStateHandler Block;
        public event FightStateHandler Wound;
        public event FightStateHandler Death;

        public Player(string name)
        {
            this.Name = name;
            hp = 100;
        }

        public void GetHit(BodyParts bodyParts)
        {
            if(bodyParts != bloked)
            {
                if(hp > 0)
                {
                    hp -= 10;
                    Wound?.Invoke(this, new FightEventArgs(Name, hp));
                }
                else
                {
                    Death?.Invoke(this, new FightEventArgs(Name, hp));
                }
            }
            else
            {
                Block?.Invoke(this, new FightEventArgs(Name, hp));
            }
        }

        public void SetBlock(BodyParts bodyParts)
        {
            bloked = bodyParts;
        }
    }
}
