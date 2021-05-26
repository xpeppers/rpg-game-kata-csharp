using System;
using System.Collections.Generic;
using Xunit;

namespace RpgGameKata.Tests
{
    public class CharacterTest
    {
        [Fact]
        public void CharacterStartsWithHealth1000()
        {
            Character c = new Character();

            Assert.Equal(1000, c.Health);
        }

        [Fact]
        public void CharacterStartsWithLevel1()
        {
            Character c = new Character();

            Assert.Equal(1, c.Level);
        }

        [Fact]
        public void CharacterStartsAlive()
        {
            Character c = new Character();

            Assert.True(c.IsAlive);
        }

        [Fact]
        public void CharacterHasDamaged()
        {
            Character c1 = new Character();
            int previousHealth = c1.Health;

            int damage = 1;
            c1.Damage(damage);

            Assert.Equal(previousHealth - damage, c1.Health);
        }

        [Fact]
        public void CharacterHasDamagedOverDeath()
        {
            Character c1 = new Character();

            int damage = c1.Health + 1;
            c1.Damage(damage);

            Assert.Equal(0, c1.Health);
            Assert.False(c1.IsAlive);
        }

        [Fact]
        public void CharacterHasDamagedExactlyToDeath()
        {
            Character c1 = new Character();

            int damage = c1.Health;
            c1.Damage(damage);

            Assert.Equal(0, c1.Health);
            Assert.False(c1.IsAlive);
        }

        [Fact]
        public void CharacterCanBeHeal()
        {
            Character c1 = new Character();

            int x = 70;
            c1.Damage(x);
            c1.Heal(x);

            Assert.Equal(1000, c1.Health);
        }

    }
}