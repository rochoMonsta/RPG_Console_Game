using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GamePrototype
{
    [DataContract]
    public class Abilities
    {
        [DataMember]
        public int Damage { get; set; }
        [DataMember]
        public string Abilitie_Name { get; set; }
        [DataMember]
        private List<Abilities> Abilities_List = new List<Abilities>();
        public void AddAbilitieToList(params Abilities[] abilities)
        {
            foreach (var element in abilities)
                Abilities_List.Add(element);
        }
        public void GetAbilitiesList()
        {
            foreach (var element in Abilities_List)
                Console.WriteLine(element);
        }
        public Abilities GetRandomAbilitie()
        {
            Random random = new Random(DateTime.Now.Millisecond);
            return Abilities_List[random.Next(Abilities_List.Count)];
        }
        public override string ToString()
        {
            return $"{Abilitie_Name} - {Damage}";
        }
    }
}
