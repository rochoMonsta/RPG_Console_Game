using System;

namespace GamePrototype
{
    sealed class CreateNewCharacher
    {
        public CreateNewCharacher() { }
        public CreateNewCharacher(Character character)
        {
            SelectCharacterClass(character);
            SelectCharacterName(character);
            SelectCharacterSex(character);
            SelectCharacterNationality(character);
        }
        public void SelectCharacterClass(Character character)
        {
            Console.WriteLine("Warrior | Bowman | Mage");
            Console.Write("Input class name: ");
            string character_class = Console.ReadLine();
            while ((character_class != "Warrior") && (character_class != "Bowman") && (character_class != "Mage"))
            {
                Console.Write("Input class name: ");
                character_class = Console.ReadLine();
            }
            switch (character_class)
            {
                case "Warrior": character.CharacterClass = new Warrior(); break;
                case "Bowman": character.CharacterClass = new Bowman(); break;
                case "Mage": character.CharacterClass = new Mage(); break;
            }
        }
        public void SelectCharacterName(Character character)
        {
            Console.Write("Enter your name: ");
            character.Name_GS = Console.ReadLine();
        }
        public void SelectCharacterSex(Character character)
        {
            Console.WriteLine("Male | Female");
            Console.Write("Enter your sex: ");
            string sex = Console.ReadLine();
            while((sex != "Male") && (sex != "Female"))
            {
                Console.WriteLine("Male | Female");
                Console.Write("Enter your sex: ");
                sex = Console.ReadLine();
            }
            character.Sex_GS = sex;
        }
        public void SelectCharacterNationality(Character character)
        {
            Console.WriteLine("Elf | Gnome | Druid | Orc");
            Console.Write("Enter your nationality: ");
            string nationality = Console.ReadLine();
            while ((nationality != "Elf") && (nationality != "Gnome") && (nationality != "Druid") && (nationality != "Orc"))
            {
                Console.WriteLine("Elf | Gnome | Druid | Orc");
                Console.Write("Enter your nationality: ");
                nationality = Console.ReadLine();
            }
            character.Nationality_GS = nationality;
        }
    }
}
