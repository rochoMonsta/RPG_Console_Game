using System;
using System.Runtime.Serialization;

namespace GamePrototype
{
    [DataContract]
    public class Bowman : CharacterClass
    {
        public Bowman() 
        {
            var abiliti1 = new Abilities() { Abilitie_Name = "Smashing shot", Damage = 40 };
            var abiliti2 = new Abilities() { Abilitie_Name = "Dagger attack", Damage = 20 };
            var abiliti3 = new Abilities() { Abilitie_Name = "Quick bow", Damage = 30 };
            Abilities.AddAbilitieToList(abiliti1, abiliti2, abiliti3);
        }
        public Bowman(int Power, int Endurance, int Intelligence, int Agility, int Stealth) : base(Power, Endurance, Intelligence, Agility, Stealth)
        {
            var abiliti1 = new Abilities() { Abilitie_Name = "Smashing shot", Damage = 40 };
            var abiliti2 = new Abilities() { Abilitie_Name = "Dagger attack", Damage = 20 };
            var abiliti3 = new Abilities() { Abilitie_Name = "Quick bow", Damage = 30 };
            Abilities.AddAbilitieToList(abiliti1, abiliti2, abiliti3);
        }
    }
}
