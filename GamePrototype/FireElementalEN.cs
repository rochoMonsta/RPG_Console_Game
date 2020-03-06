using System;

namespace GamePrototype
{
    class FireElementalEN : Enemy
    {
        public FireElementalEN() { }
        public FireElementalEN(Character character)
        {
            Random random = new Random(DateTime.Now.Millisecond);
            Name = "Fire Elemental";
            Atack_Power = 100 + (character.CharacterLevel.CHARACTER_LEVEL_GS * 20);
            Level = character.CharacterLevel.CHARACTER_LEVEL_GS + random.Next(0, 4);
            Health = 100 + character.health.Health_GS;
            Anymation = @"\C:FireElemental.animanion";
            
        }
    }
}
