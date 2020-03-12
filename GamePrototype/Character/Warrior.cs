using System;
using System.Runtime.Serialization;

namespace GamePrototype
{
    [DataContract]
    public class Warrior : CharacterClass
    {
        public Warrior() 
        {
            var abiliti1 = new Abilities() { Abilitie_Name = "Throwing an ax", Damage = 20 };
            var abiliti2 = new Abilities() { Abilitie_Name = "Blow with a shield", Damage = 50 };
            var abiliti3 = new Abilities() { Abilitie_Name = "Battlerage", Damage = 45 };
            Abilities.AddAbilitieToList(abiliti1, abiliti2, abiliti3);
        }
        public Warrior(int Power, int Endurance, int Intelligence, int Agility, int Stealth) : base(Power, Endurance, Intelligence, Agility, Stealth)
        {
            var abiliti1 = new Abilities() { Abilitie_Name = "Throwing an ax", Damage = 20 };
            var abiliti2 = new Abilities() { Abilitie_Name = "Blow with a shield", Damage = 50 };
            var abiliti3 = new Abilities() { Abilitie_Name = "Battlerage", Damage = 45 };
            Abilities.AddAbilitieToList(abiliti1, abiliti2, abiliti3);
        }
    }
}
