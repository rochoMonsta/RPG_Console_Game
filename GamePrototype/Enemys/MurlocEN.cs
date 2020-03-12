using System;

namespace GamePrototype.Enemys
{
    class MurlocEN : Enemy
    {
        public MurlocEN() { }
        public MurlocEN(Character character)
        {
            Random random = new Random(DateTime.Now.Millisecond);
            Name = "Murloc scout";
            Atack_Power = 10 + (character.CharacterLevel.CHARACTER_LEVEL_GS * 20);
            Level = character.CharacterLevel.CHARACTER_LEVEL_GS + random.Next(1, 4);
            EXP_BY_KILLING = (Level * 10) + 10;
            Health.Health_GS = 10 + character.Health.Health_GS;
            Anymation = @"\C:MurlocScout.animanion";
            if (character.CharacterClass.Luck >= 2)
                Luck = character.CharacterClass.Luck - 2;
            else
                Luck = 1;
        }
        public override void Attack(Character character)
        {
            Console.WriteLine("Fin kick - " + Atack_Power);
            Random random = new Random(DateTime.Now.Millisecond);
            if ((character.CharacterClass.Luck * 10) >= random.Next(1, 101))
                Console.WriteLine($"\t{Name}: MISS ATACK\n");
            else
            {
                Console.WriteLine($"\t{Name}: ATACK {character.Name_GS}");
                character.Health.HealthMinuses(character, this.Atack_Power);
                Console.WriteLine($"\t{Name} HP: {Health.Health_GS}    {character.Name_GS} HP: {character.Health.Health_GS}\n");
            }
        }
    }
}
