﻿using System;
using System.Runtime.Serialization;

namespace GamePrototype
{
    [DataContract]
    public class CharacterLevel
    {
        [DataMember]
        private int CHARACTER_LEVEL = 0;
        [DataMember]
        private const int UP_LEVEL_BOUNDARY = 100;
        [DataMember]
        private int CHARACTER_LEVEL_POINTS = 0;
        [DataMember]
        private int CHARACTER_EXPERIENCE_POINTS = 15;
        public int GET_EXPERIENCE_POINT
        {
            get { return CHARACTER_EXPERIENCE_POINTS; }
            set { CHARACTER_EXPERIENCE_POINTS = value; }
        }
        public int ADD_EXPERIENCE_POINT(Character character)
        {
            if (CHARACTER_LEVEL_POINTS_GS >= UP_LEVEL_BOUNDARY)
            {
                Console.WriteLine($"Level UP: {CHARACTER_LEVEL_GS} -> {CHARACTER_LEVEL_GS + 1}");
                CHARACTER_LEVEL_GS++;
                CHARACTER_EXPERIENCE_POINTS += CHARACTER_LEVEL_POINTS_GS / UP_LEVEL_BOUNDARY;
                CHARACTER_LEVEL_POINTS_GS = CHARACTER_LEVEL_POINTS_GS % UP_LEVEL_BOUNDARY;
                character.CharacterClass.Abilities.UpAbilitiesLevel();
                character.Health.HealthUp(character);
                return CHARACTER_EXPERIENCE_POINTS;
            }
            else
                return 0;
        }
        public int CHARACTER_LEVEL_POINTS_GS
        {
            get { return CHARACTER_LEVEL_POINTS; }
            set { CHARACTER_LEVEL_POINTS = value; }
        }
        public int CHARACTER_LEVEL_GS
        {
            get { return CHARACTER_LEVEL; }
            set { CHARACTER_LEVEL = value; }
        }
        public override string ToString()
        {
            return $"LVL: {CHARACTER_LEVEL_GS}; Level up points: {CHARACTER_LEVEL_POINTS_GS}; Exp points: {CHARACTER_EXPERIENCE_POINTS}";
        }
    }
}
