using System;
using Xunit;

namespace RpgGameKata.Tests
{
	public class ExampleTest
	{
		[Fact]
		public void Damage_To_Character_Decrease_His_Health()
		{
			Character character1 = new Character();
			Character character2 = new Character();

			character1.Attack(character2, 1);
			Assert.Equal(999, character2.Health);

		}

		[Fact]
		public void Damage_To_Character_When_Damage_Exceeds_Health()
		{
			Character character1 = new Character();
			Character character2 = new Character();

			character1.Attack(character2, 1001);

			Assert.Equal(0, character2.Health);
            Assert.False(character2.IsAlive);
        }
	}

	public class Character
	{
		public int Health { get; set; } = 1000;
		public bool IsAlive { get
			{
				return Health > 0;
			}
		}

        internal void Attack(Character character2, int damage)
		{
			character2.Health -= Math.Min(character2.Health, damage);
		}
	}
}