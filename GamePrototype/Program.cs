using System;

namespace GamePrototype
{
    class Program
    {
        static void Main(string[] args)
        {
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
