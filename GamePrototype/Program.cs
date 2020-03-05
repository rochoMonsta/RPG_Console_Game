using System;
using System.IO;

namespace GamePrototype
{
    class Program
    {
        static void Main(string[] args)
        {
            //Version 0.0.01
            //Date: 29.02.2020
            //Create character and CHARACTERISTICS_update

            //Tasks for next update:
            //create world
            //correct save(CharacterClass)
            Character character = new Character();
            if (File.Exists("Character.json"))
            {
                var gameSaverLoader = new GameSaverLoader();
                character = gameSaverLoader.LOAD_GAME_SAVES();
                Console.WriteLine($"{character.Name_GS} {character.Sex_GS} {character.Nationality_GS}");
                Console.WriteLine(character.CharacterClass);
                character.CharacterClass.Ability();
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
            }
            Console.ReadLine();
        }
    }
}
