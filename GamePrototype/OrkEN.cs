using System;

namespace GamePrototype
{
    public class OrkEN : Enemy
    {
        public OrkEN() { }
        public OrkEN(Character character)
        {
            Random random = new Random(DateTime.Now.Millisecond);
            Name = "Orc robber";
            Atack_Power = 25 + (character.CharacterLevel.CHARACTER_LEVEL_GS * 20);
            Level = character.CharacterLevel.CHARACTER_LEVEL_GS + random.Next(0, 4);
            Health = 50 + character.health.Health_GS;
            Anymation = @"\C:OrkRobber.animanion";
        }
    }
}
