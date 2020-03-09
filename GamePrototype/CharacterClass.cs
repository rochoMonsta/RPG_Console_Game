using System;
using System.Runtime.Serialization;

namespace GamePrototype
{
    [DataContract]
    public class CharacterClass
    {
        [DataMember]
        public int Power { get; set; }
        [DataMember]
        public int Endurance { get; set; }
        [DataMember]
        public int Intelligence { get; set; }
        [DataMember]
        public int Agility { get; set; }
        [DataMember]
        public int Stealth { get; set; }
        [DataMember]
        public int Luck { get; set; }
        public CharacterClass() { }
        public CharacterClass(int Power, int Endurance, int Intelligence, int Agility, int Stealth)
        {
            if (Power <= 0)
                throw new ArgumentException(nameof(Power), "Wrong power.");
            else
                this.Power = Power;

            if (Endurance <= 0)
                throw new ArgumentException(nameof(Endurance), "Wrong endurance.");
            else
                this.Endurance = Endurance;

            if (Intelligence <= 0)
                throw new ArgumentException(nameof(Intelligence), "Wrong intelligence.");
            else
                this.Intelligence = Intelligence;

            if (Agility <= 0)
                throw new ArgumentException(nameof(Agility), "Wrong agility.");
            else
                this.Agility = Agility;

            if (Stealth <= 0)
                throw new ArgumentException(nameof(Stealth), "Wrong agility.");
            else
                this.Stealth = Stealth;
        }
        public virtual void Ability() { }
        public override string ToString()
        {
            return $"Power: {Power}\nEndurance: {Endurance}\nIntelligence: {Intelligence}\nAgility: {Agility}\nStealth: {Stealth}";
        }
    }
}
