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

    }
}