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
            Health.Health_GS = 50 + character.Health.Health_GS;
            Anymation = @"\C:OrkRobber.animanion";
            Luck = character.CharacterClass.Luck - 1;
        }
        public override void Attack(Character character)
        {
            Console.WriteLine("Blow with an ax.");
            Random random = new Random(DateTime.Now.Millisecond);
            if ((character.CharacterClass.Luck * 10) >= random.Next(1, 101))
                Console.WriteLine("Ork robber: MISS ATACK");
            else
                character.Health.HealthMinuses(character, this.Atack_Power);
        }
    }
}
