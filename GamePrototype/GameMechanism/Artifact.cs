using System;

namespace GamePrototype.GameMechanism
{
    public class Artifact
    {
        public string Name { get; set; }
        public string ArtifactUPCharacteristic { get; set; }
        public int Bonus { get; set; }
        public override string ToString()
        {
            return $"{Name} - {ArtifactUPCharacteristic} - {Bonus}";
        }
        public void GetArtifactBonuses(Character character)
        {
            switch (ArtifactUPCharacteristic)
            {
                case "Power": character.CharacterClass.Power += Bonus; break;
                case "Endurance": character.CharacterClass.Endurance += Bonus; break;
                case "Intelligence": character.CharacterClass.Intelligence += Bonus; break;
                case "Agility": character.CharacterClass.Agility += Bonus; break;
                case "Stealth": character.CharacterClass.Stealth += Bonus; break;
                case "Luck": character.CharacterClass.Luck += Bonus; break;
            }
        }
        public Artifact GetRandomArtifact()
        {
            Random random = new Random(DateTime.Now.Millisecond);
            string[] ArtifactOwnerName = { "Dragon", "Zombie", "Rabbit", "Snake", "Witch", "King" };
            string[] Artifact = { "eye", "spear", "sword", "tooth", "skin" };
            string[] ArtifactUPCharacteristic = { "Power", "Endurance", "Intelligence", "Agility", "Stealth", "Luck" };
            int bonus = 0;
            string characteristic = ArtifactUPCharacteristic[random.Next(ArtifactUPCharacteristic.Length)];
            switch (characteristic)
            {
                case "Power": bonus = random.Next(0, 3); break;
                case "Endurance": bonus = random.Next(0, 3); break;
                case "Intelligence": bonus = random.Next(0, 3); break;
                case "Agility": bonus = random.Next(0, 3); break;
                case "Stealth": bonus = random.Next(0, 3); break;
                case "Luck": bonus = random.Next(0, 2); break;
            }
            Artifact artifact = new Artifact()
            {
                Name = ArtifactOwnerName[random.Next(ArtifactOwnerName.Length)] + " " + Artifact[random.Next(Artifact.Length)],
                ArtifactUPCharacteristic = characteristic,
                Bonus = bonus
            };
            return artifact;
        }
    }
}
