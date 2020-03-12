using System;

namespace GamePrototype
{
    public class Health
    {
        private int CharacterHealthUpBoundary = 100;
        public int CharacterHealthUpBoundary_GS
        {
            get { return CharacterHealthUpBoundary; }
            set { CharacterHealthUpBoundary = value; }
        }
        public int Health_GS { get; set; } = 100;
        public void HealthUp(Character character)
        {
            character.Health.CharacterHealthUpBoundary_GS += 50;
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
