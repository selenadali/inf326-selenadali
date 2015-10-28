using System;
using NUnit.Framework;

namespace AssertDemo2.Tests.Ranges
{
    [TestFixture]
    public class PlayerCharacterTests
    {
        [Test]
        public void ShouldIncreaseHealthAfterSleeping()
        {
            var sut = new PlayerCharacter {Health = 100};
            sut.Sleep();
            Assert.That(sut.Health, Is.GreaterThan(100));
        }
    }

}
