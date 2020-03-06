using System;

namespace GamePrototype
{
    public class Enemy
    {
        public string Anymation { get; set; }
        public int Atack_Power { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public int Health { get; set; }
        public Enemy() { }
        public Enemy(Character character) { }
        public override string ToString()
        {
            return $"Name: {Name}\nLevel: {Level}\nHealth: {Health}\nAtack_Power: {Atack_Power}";
        }
    }
}
