using Xunit;

namespace RpgGameKata.Tests
{
    public class CharacterTest
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
}