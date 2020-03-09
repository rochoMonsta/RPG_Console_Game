using System;
using System.IO;

namespace GamePrototype
{
    class Program
    {
        public static bool GameStatus = true;
        static void Main(string[] args)
        {
            //Version 0.0.01
            //Date: 29.02.2020
            //Create character and CHARACTERISTICS_update

            //Tasks for next update:
            //create world
            //correct save(CharacterClass)

            //TEST FIELD
            Character character = new Character();
            if (File.Exists("Character.json"))
            {
                var gameSaverLoader = new GameSaverLoader();
                character = gameSaverLoader.LOAD_GAME_SAVES();
                Console.WriteLine($"{character.Name_GS} {character.Sex_GS} {character.Nationality_GS} {character.Health.Health_GS}");
                Console.WriteLine(character.CharacterClass);
                character.CharacterClass.Ability();

                character.GET_CHARACTER_CHARACTERISTICS();
                Fight fight = new Fight();
                OrkEN orkEN = new OrkEN(character);
                Console.WriteLine(orkEN + "\n");
                fight.Fight_HeroVSEnemy(character, orkEN);
                character.GET_CHARACTER_CHARACTERISTICS();
            }
            else
            {
                CreateNewCharacher createNew = new CreateNewCharacher(character);
                Console.Clear();
                Console.WriteLine(character);
                character.CharacterClass.Ability();

                CharacterCharacteristics characterCharacteristics = new CharacterCharacteristics(character);
                character.GET_CHARACTER_CHARACTERISTICS();

                var gameSaverLoader = new GameSaverLoader();
                gameSaverLoader.SAVE_GAME(character);

                character.GET_CHARACTER_CHARACTERISTICS();
                Fight fight = new Fight();
                OrkEN orkEN = new OrkEN(character);
                Console.WriteLine(orkEN + "\n");
                fight.Fight_HeroVSEnemy(character, orkEN);
                character.GET_CHARACTER_CHARACTERISTICS();
            }
            Console.ReadLine();
        }
    }
}
