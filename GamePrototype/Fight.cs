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
                if (enemy.Health.Health_GS <= 0)
                    break;
                enemy.Attack(character);
                if (character.Health.Health_GS <= 0)
                    break;
            }
            if (character.Health.Health_GS <= 0)
                Console.WriteLine($"{character.Name_GS}: DIE;");
            else
            {
                character.CharacterLevel.CHARACTER_LEVEL_POINTS_GS += enemy.EXP_BY_KILLING;
                character.CharacterLevel.ADD_EXPERIENCE_POINT();
            }
            if (enemy.Health.Health_GS <= 0)
                Console.WriteLine($"{enemy.Name}: DIE;");
        }
    }
}
