using System;

namespace GamePrototype
{
    class Mage : CharacterClass
    {
        public Mage() { }
        public Mage(int Power, int Endurance, int Intelligence, int Agility, int Stealth) : base(Power, Endurance, Intelligence, Agility, Stealth)
        {

        }
        public override void Ability()
        {
            Console.WriteLine("Fireball rain");
        }
    }
}
