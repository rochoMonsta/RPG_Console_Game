using System;

namespace GamePrototype
{
    public class Health
    {
        public int Health_GS { get; set; } = 100;
        public void HealthUp(Character character)
        {
            character.Health.Health_GS += (character.CharacterLevel.CHARACTER_LEVEL_GS * 50);
        }
        public void HealthUp(Enemy enemy)
        {
            enemy.Health.Health_GS += (enemy.Level * 50);
        }
        public void HealthMinuses(Character character, int atack_power)
        {
            character.Health.Health_GS -= atack_power;
        }
        public void HealthMinuses(Enemy enemy, int atack_power)
        {
            enemy.Health.Health_GS -= atack_power;
        }
    }
}
