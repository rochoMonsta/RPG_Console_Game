using System;

namespace GamePrototype
{
    class Program
    {
        static void Main(string[] args)
        {
            //Version 0.0.01
            //Date: 29.02.2020
            //Create character and CHARACTERISTICS_update
            Character character = new Character();
            CreateNewCharacher createNew = new CreateNewCharacher(character);

            Console.Clear();
            Console.WriteLine(character);
            character.CharacterClass.Ability();

            CharacterCharacteristics characterCharacteristics = new CharacterCharacteristics(character);
            character.GET_CHARACTER_CHARACTERISTICS();

            Console.ReadLine();
        }
    }
}
