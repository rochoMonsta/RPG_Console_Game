using System;

namespace GamePrototype
{
    class CharacterLevel
    {
        private int CHARACTER_LEVEL = 0;
        private const int UP_LEVEL_BOUNDARY = 100;
        private int CHARACTER_LEVEL_POINTS = 0;
        private int CHARACTER_EXPERIENCE_POINTS = 15;
        public int GET_EXPERIENCE_POINT
        {
            get { return CHARACTER_EXPERIENCE_POINTS; }
            set { CHARACTER_EXPERIENCE_POINTS = value; }
        }
        public int ADD_EXPERIENCE_POINT()
        {
            int EXPERIENCE_POINTS = 0;
            if (CHARACTER_LEVEL_POINTS_GS >= UP_LEVEL_BOUNDARY)
            {
                CHARACTER_LEVEL_GS++;
                EXPERIENCE_POINTS = CHARACTER_LEVEL_POINTS_GS / UP_LEVEL_BOUNDARY;
                CHARACTER_LEVEL_POINTS_GS = Math.Abs(CHARACTER_LEVEL_POINTS_GS % UP_LEVEL_BOUNDARY);
                return EXPERIENCE_POINTS;
            }
            else
                return 0;
        }
        public int CHARACTER_LEVEL_POINTS_GS
        {
            get { return CHARACTER_LEVEL_POINTS; }
            set { CHARACTER_LEVEL_POINTS += value; }
        }
        public int CHARACTER_LEVEL_GS
        {
            get { return CHARACTER_LEVEL; }
            set { CHARACTER_LEVEL += value; }
        }
    }
}
