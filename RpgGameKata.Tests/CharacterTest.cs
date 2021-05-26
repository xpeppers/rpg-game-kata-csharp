using Xunit;

namespace RpgGameKata.Tests
{
    public class CharacterTest
	{
		[Fact]
		public void Damage_To_Character_Decrease_His_Health()
		{
			Character attacker = new Character();
			Character target = new Character();

			attacker.Attack(target, 1);
			Assert.Equal(999, target.Health);

		}

		[Fact]
		public void Damage_To_Character_When_Damage_Exceeds_Health()
		{
			Character attacker = new Character();
			Character target = new Character();

			attacker.Attack(target, 1001);

			Assert.Equal(0, target.Health);
            Assert.False(target.IsAlive);
        }
	}
}