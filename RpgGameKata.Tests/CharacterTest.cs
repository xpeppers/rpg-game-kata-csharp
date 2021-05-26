using System;
using System.Collections.Generic;
using Xunit;

namespace RpgGameKata.Tests
{
    public class CharacterTest
    {
        const int HealthLimit = 1000;

        [Fact]
        public void CharacterStartsWithHealth1000()
        {
            Character c = new Character();

            Assert.Equal(HealthLimit, c.Health);
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
            Character Attacker = new Character();
            Character Defender = new Character();

            int previousHealth = Defender.Health;

            int damage = 1;
            Attacker.DealDamage(Defender, damage);

            Assert.Equal(previousHealth - damage, Defender.Health);
        }

        [Fact]
        public void CharacterHasDamagedOverDeath()
        {
            Character Attacker = new Character();
            Character Defender = new Character();

            int damage = Defender.Health + 1;
            Attacker.DealDamage(Defender, damage);

            Assert.Equal(0, Defender.Health);
            Assert.False(Defender.IsAlive);
        }

        [Fact]
        public void CharacterHasDamagedExactlyToDeath()
        {
            Character Attacker = new Character();
            Character Defender = new Character();

            int damage = Defender.Health;
            Attacker.DealDamage(Defender, damage);

            Assert.Equal(0, Defender.Health);
            Assert.False(Defender.IsAlive);
        }

        [Fact]
        public void CharacterCanBeHeal()
        {
            Character Attacker = new Character();
            Character Defender = new Character();

            int x = 70;
            Attacker.DealDamage(Defender, x);
            Defender.Heal(x);

            Assert.Equal(HealthLimit, Defender.Health);
        }

        [Fact]
        public void CharacterHealthCannotBeOver1000()
        {
            Character Attacker = new Character();
            Character Defender = new Character();

            int x = 70;
            Attacker.DealDamage(Defender, x);
            Defender.Heal(x + 1);

            Assert.Equal(HealthLimit, Defender.Health);
        }

        [Fact]
        public void DeadCharacterCannotBeHealt()
        {
            Character Attacker = new Character();
            Character Defender = new Character();

            Attacker.DealDamage(Defender, HealthLimit);
            Defender.Heal(1);

            Assert.Equal(0, Defender.Health);
            Assert.False(Defender.IsAlive);
        }

        [Fact]
        public void CharacterCannotDamageHimself()
        {
            Character c1 = new Character();

            int previousHealth = c1.Health;
            c1.DealDamage(c1, 1);

            Assert.Equal(previousHealth, c1.Health);
        }
    }
}