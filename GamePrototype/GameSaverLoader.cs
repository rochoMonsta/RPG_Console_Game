using System;
using System.IO;
using System.Runtime.Serialization.Json;

namespace GamePrototype
{
    class GameSaverLoader
    {
        public void SAVE_GAME(Character character)
        {
            var json_formatter = new DataContractJsonSerializer(typeof(Character));

            using (var file = new FileStream("Character.json", FileMode.Create))
                json_formatter.WriteObject(file, character);
        }
        public Character LOAD_GAME_SAVES()
        {
            var json_formatter = new DataContractJsonSerializer(typeof(Character));

            using (var file = new FileStream("Character.json", FileMode.OpenOrCreate))
            {
                var character = json_formatter.ReadObject(file) as Character;
                if (character != null)
                    return character;
            }
            return null;
        }
    }
}
