using System;

namespace GamePrototype
{
    public class Health
    {
        public int Health_GS { get; set; } = 100;
        public void HealthUp(Character character)
        {
            character.health.Health_GS += (character.CharacterLevel.CHARACTER_LEVEL_GS * 50);
        }
        public void HealthMinuses(Character character, int atack_power)
        {
            character.health.Health_GS -= atack_power;
        }
    }
}
