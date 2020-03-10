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
            Health.Health_GS = 100 + character.Health.Health_GS;
            Anymation = @"\C:FireElemental.animanion";
        }
        public override void Attack(Character character)
        {
            Console.WriteLine("Earthquake - " + Atack_Power);
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
