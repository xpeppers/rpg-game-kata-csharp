using System.Collections.Generic;

namespace RpgGameKata
{
    public class Character
    {
        public Character()
        {
            Health = 1000;

            Level = 1;
        }

        public int Health { get; private set; }
        public int Level { get; private set; }
    }
}