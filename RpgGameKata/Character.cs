using System;
using System.Collections.Generic;

namespace RpgGameKata
{
    public class Character
    {
        const int HealthLimit = 1000;

        public int Health { get; private set; } = HealthLimit;

        public int Level { get; private set; } = 1;

        public bool IsAlive
        {
            get { return Health > 0; }
        }

        public void Damage(int damage)
        {
            if (damage >= Health)
            {
                Health = 0;
            }
            else
                Health -= damage;
        }

        public void Heal(int heal)
        {
            if (!IsAlive)
                return;

            Health += heal;
            if (Health > HealthLimit)
                Health = HealthLimit;
        }

        public void Damage(Character character, int damage)
        {
            if (character.Equals(this))
                return;
        }
    }
}