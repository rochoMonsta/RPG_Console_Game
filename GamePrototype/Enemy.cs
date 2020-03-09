using System;

namespace GamePrototype
{
    public class Enemy
    {
        public string Anymation { get; set; }
        public int Atack_Power { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public Health Health = new Health();
        public int Luck { get; set; }
        public Enemy() { }
        public Enemy(Character character) { }
        public override string ToString()
        {
            return $"Name: {Name}\nLevel: {Level}\nHealth: {Health.Health_GS}\nAtack_Power: {Atack_Power}\nLuck: {Luck}";
        }
        public virtual void Attack(Character character)
        {

        }
    }
}
