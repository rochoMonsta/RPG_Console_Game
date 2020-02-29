using System;

namespace GamePrototype
{
    class Bowman : CharacterClass
    {
        public Bowman() { }
        public Bowman(int Power, int Endurance, int Intelligence, int Agility, int Stealth) : base(Power, Endurance, Intelligence, Agility, Stealth)
        {

        }
        public override void Ability()
        {
            Console.WriteLine("Breaking arrow");
        }
    }
}
