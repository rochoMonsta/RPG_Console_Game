﻿using System;

namespace GamePrototype
{
    class CharacterClass
    {
        public int Power { get; set; }
        public int Endurance { get; set; }
        public int Intelligence { get; set; }
        public int Agility { get; set; }
        public int Stealth { get; set; }
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
    }
}