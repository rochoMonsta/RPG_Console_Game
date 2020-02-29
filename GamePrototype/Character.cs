﻿using System;

namespace GamePrototype
{
    class Character
    {
        private string Name;
        private string Sex;
        private string Nationality;
        public CharacterLevel CharacterLevel = new CharacterLevel();
        public CharacterClass CharacterClass;
        public Character() { }
        public Character(string Sex, string Name, string Nationality, CharacterClass character)
        {
            if(string.IsNullOrWhiteSpace(Name))
                throw new ArgumentNullException(nameof(Name), "Wrong type of Name.");
            else
                this.Name = Name;

            if (string.IsNullOrWhiteSpace(Sex))
                throw new ArgumentNullException(nameof(Sex), "Wrong type of Sex.");
            else
                this.Sex = Sex;

            if (string.IsNullOrWhiteSpace(Nationality))
                throw new ArgumentNullException(nameof(Nationality), "Wrong type of Nationality.");
            else
                this.Nationality = Nationality;

            this.CharacterClass = character;
        }
        public string Name_GS
        {
            get { return this.Name; }
            set { this.Name = value; }
        }
        public string Sex_GS
        {
            get { return this.Sex; }
            set { this.Sex = value; }
        }
        public string Nationality_GS
        {
            get { return this.Nationality; }
            set { this.Nationality = value; }
        }
        public override string ToString()
        {
            return $"{Name_GS} - {Sex_GS} - {Nationality_GS} - {CharacterClass.GetType()}";
        }
        public void GET_CHARACTER_CHARACTERISTICS()
        {
            Console.WriteLine($"{this.Name} Power: " + this.CharacterClass.Power);
            Console.WriteLine($"{this.Name} Endurance: " + this.CharacterClass.Endurance);
            Console.WriteLine($"{this.Name} Intelligence: " + this.CharacterClass.Intelligence);
            Console.WriteLine($"{this.Name} Agility: " + this.CharacterClass.Agility);
            Console.WriteLine($"{this.Name} Stealth: " + this.CharacterClass.Stealth);
        }
    }
}