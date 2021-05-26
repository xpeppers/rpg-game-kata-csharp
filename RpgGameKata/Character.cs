using System;
using System.Collections.Generic;

namespace RpgGameKata
{
    public class Character
    {


        public int Health { get; private set; } = 1000;

        public int Level { get; private set; } = 1;

        public bool IsAlive { get; private set; } = true;

        public void Damage(int damage)
        {
            if (damage >= Health)
            {
                Health = 0;
                IsAlive = false;
            }
            else
                Health -= damage;
        }

        public void Heal(int heal)
        {
            Health += heal;
            if (Health > 1000)
                Health = 1000;
        }
    }
}