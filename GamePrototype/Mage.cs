using System;
using System.Runtime.Serialization;

namespace GamePrototype
{
    [DataContract] 
    public class Mage : CharacterClass
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
