using System;

namespace GamePrototype
{
    sealed class CharacterCharacteristics
    {
        public CharacterCharacteristics() { }
        public CharacterCharacteristics(Character character)
        {
            CHOICE_OF_INITIAL_CHARACTERISTICS(character);
        }
        public void CHOICE_OF_INITIAL_CHARACTERISTICS(Character character)
        {
            while(character.CharacterLevel.GET_EXPERIENCE_POINT != 0)
            {
                string characteristic = CHOOSE_THE_CHARACTERISTICS();
                int skillPoint = ENTER_THE_NUMBER_OF_POINTS_TO_IMPROVE(character);
                IMPROVEMENT_OF_CHARACTERISTICS_OF_CHARACTERISTICS(character, characteristic, skillPoint);
            }
        }
        public void IMPROVEMENT_OF_CHARACTERISTICS_OF_CHARACTERISTICS(Character character, string characteristic, int skillPoint)
        {
            switch (characteristic)
            {
                case "Power": character.CharacterClass.Power += skillPoint; break;
                case "Endurance": character.CharacterClass.Endurance += skillPoint; break;
                case "Intelligence": character.CharacterClass.Intelligence += skillPoint; break;
                case "Agility": character.CharacterClass.Agility += skillPoint; break;
                case "Stealth": character.CharacterClass.Stealth += skillPoint; break;
            }
        }
        private string CHOOSE_THE_CHARACTERISTICS()
        {
            Console.WriteLine("Power | Endurance | Intelligence | Agility | Stealth");
            Console.Write("Select a characteristic: ");
            string cha = Console.ReadLine();
            while((cha != "Power") && (cha != "Endurance") && (cha != "Intelligence") && (cha != "Agility") && (cha != "Stealth"))
            {
                Console.WriteLine("Power | Endurance | Intelligence | Agility | Stealth");
                Console.Write("Select a characteristic: ");
                cha = Console.ReadLine();
            }
            Console.Clear();
            return cha;
        }
        private int ENTER_THE_NUMBER_OF_POINTS_TO_IMPROVE(Character character)
        {
            Console.WriteLine($"Skill points: {character.CharacterLevel.GET_EXPERIENCE_POINT}");
            int skill_points = 0;
            if (character.CharacterLevel.GET_EXPERIENCE_POINT != 0)
            {
                Console.Write("Enter points to improve your level of performance: ");
                skill_points = Convert.ToInt32(Console.ReadLine());

                while (skill_points > character.CharacterLevel.GET_EXPERIENCE_POINT)
                {
                    Console.WriteLine($"You have: {character.CharacterLevel.GET_EXPERIENCE_POINT}");
                    Console.Write("Enter points to improve your level of performance: ");
                    skill_points = Convert.ToInt32(Console.ReadLine());
                }
                character.CharacterLevel.GET_EXPERIENCE_POINT = character.CharacterLevel.GET_EXPERIENCE_POINT - skill_points;
            }
            return skill_points;
        }
    }
}
