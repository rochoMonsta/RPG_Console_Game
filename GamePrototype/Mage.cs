using System;
using System.Runtime.Serialization;

namespace GamePrototype
{
    [DataContract] 
    public class Mage : CharacterClass
    {
        public Mage() 
        {
            var abiliti1 = new Abilities() { Abilitie_Name = "Fireball rain", Damage = 50 };
            var abiliti2 = new Abilities() { Abilitie_Name = "Fire wall", Damage = 20 };
            var abiliti3 = new Abilities() { Abilitie_Name = "Ice bullet", Damage = 35 };
            Abilities.AddAbilitieToList(abiliti1, abiliti2, abiliti3);
        }
        public Mage(int Power, int Endurance, int Intelligence, int Agility, int Stealth) : base(Power, Endurance, Intelligence, Agility, Stealth)
        {
            var abiliti1 = new Abilities() { Abilitie_Name = "Fireball rain", Damage = 50 };
            var abiliti2 = new Abilities() { Abilitie_Name = "Fire wall", Damage = 20 };
            var abiliti3 = new Abilities() { Abilitie_Name = "Ice bullet", Damage = 35 };
            Abilities.AddAbilitieToList(abiliti1, abiliti2, abiliti3);
        }
    }
}
