using System;
using System.Runtime.Serialization;

namespace GamePrototype
{
    [DataContract]
    public class Bowman : CharacterClass
    {
        public Bowman() { }
        public Bowman(int Power, int Endurance, int Intelligence, int Agility, int Stealth) : base(Power, Endurance, Intelligence, Agility, Stealth)
        {

        }
    }
}
