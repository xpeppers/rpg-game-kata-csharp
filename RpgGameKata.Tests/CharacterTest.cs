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
		
		[Fact]
		public void Heal_Character_Increase_Own_Health()
		{
			Character player = new Character();
			Character attacker = new Character();

			attacker.Attack(player, 500);
			player.Heal(1);

			Assert.Equal(501, player.Health);
		}

		[Fact]
		public void Cannot_Heal_Over_Maximum_Health()
        {
            Character player = new Character();

            player.Heal(1);

            Assert.Equal(1000, player.Health);
        }
    }
}