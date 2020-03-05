using System;

namespace GamePrototype
{
    public class Enemy
    {
        private const int DEFAULT_HEALTH = 100;
        private const int DEFAULT_ATACK = 50;
        public string Anymation { get; set; }
        public int Atack_Power { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public int Health { get; set; }
        public Enemy() { }
        public Enemy(Character character)
        {
            Level = character.CharacterLevel.CHARACTER_LEVEL_GS + 1;
            Health = character.CharacterLevel.CHARACTER_LEVEL_GS * 15 + DEFAULT_HEALTH;
            Atack_Power = character.CharacterClass.Power + DEFAULT_ATACK;
        }
        public override string ToString()
        {
            return $"Name: {Name}\nLevel: {Level}\nHealth: {Health}\nAtack_Power: {Atack_Power}";
        }
    }
}
