using System;
using System.Runtime.Serialization;

namespace GamePrototype
{
    [DataContract]
    public class Warrior : CharacterClass
    {
        public Warrior() { }
        public Warrior(int Power, int Endurance, int Intelligence, int Agility, int Stealth) : base(Power, Endurance, Intelligence, Agility, Stealth)
        {

        }
        public override void Ability()
        {
            Console.WriteLine("Tearing blow");
        }
    }
}
