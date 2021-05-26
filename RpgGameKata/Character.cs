using System;

namespace RpgGameKata
{
    public class Character
	{
		public int Health { get; set; } = 1000;
		public bool IsAlive { get
			{
				return Health > 0;
			}
		}

        public void Attack(Character character2, int damage)
		{
			character2.Health -= Math.Min(character2.Health, damage);
		}

        public void Heal(int healValue)
        {
			this.Health += healValue;
        }
    }
}