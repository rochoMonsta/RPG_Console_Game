using System;

namespace GamePrototype
{
    class Fight
    {
        public Fight() { }
        public void Fight_HeroVSEnemy(Character character, Enemy enemy)
        {
            while (character.Health.Health_GS >= 0 && enemy.Health.Health_GS >= 0)
            {
                character.Attack(enemy);
                enemy.Attack(character);
            }
            if (character.Health.Health_GS <= 0)
                Console.WriteLine($"{character.Name_GS}: DIE;");
            if (enemy.Health.Health_GS <= 0)
                Console.WriteLine($"{enemy.Name}: DIE;");
        }
    }
}
