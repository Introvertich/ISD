namespace FightClub
{
    enum BodyParts
    {
        Head, Body, Legs
    }


    class Player
    {
        public string Name { get; }
        public int HP { get; set; }
        public BodyParts Bloked { get; set; }

        
        public delegate void FightStateHandler(object sender, FightEventArgs e);
        public event FightStateHandler Block;
        public event FightStateHandler Wound;
        public event FightStateHandler Death;

        public Player(string name)
        {
            this.Name = name;
            HP = 100;
        }

        public void GetHit(BodyParts bodyParts)
        {
            if(bodyParts != Bloked)
            {
                if(HP > 0)
                {
                    HP -= 10;
                    Wound?.Invoke(this, new FightEventArgs(Name, HP));
                }
                else
                {
                    Death?.Invoke(this, new FightEventArgs(Name, HP));
                }
            }
            else
            {
                Block?.Invoke(this, new FightEventArgs(Name, HP));
            }
        }

        public void SetBlock(BodyParts bodyParts)
        {
            Bloked = bodyParts;
        }
    }
}
