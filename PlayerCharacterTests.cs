
using NUnit.Framework;

namespace AssertDemo2.Tests.Ranges
{
    [TestFixture]
    public class PlayerCharacterTests
    {
        [Test]
        public void ShouldIncreaseHealthAfterSleeping()
        {
            //Bu test StartingWeapons'u kaldırınca çalıştı 
            var sut = new PlayerCharacter {Health = 100};
            sut.Sleep();
            Assert.That(sut.Health, Is.GreaterThan(100));
        }

        [Test]
        public void ShouldHaveDefaultRandomGeneratedName()
        {
            //GenerateName() metodunu kapatıp Name=""; => FAIL
            var sut = new PlayerCharacter();
            Assert.That(sut.Name, Is.Not.Empty);
        }

        [Test]
        public void ShouldHaveANickName()
        {
            var sut= new PlayerCharacter();
            Assert.That(sut.NickName, Is.Null);
        }

        [Test]
        public void ShouldBeNewbie()
        {
            var sut=new PlayerCharacter();
            Assert.That(sut.IsNoob, Is.True);
        }

        [Test]
        public void ShouldHaveEmptyDefaultWeapons()
        {
            var sut=new PlayerCharacter();
            Assert.That(sut.Weapons, Is.All.Not.Empty);
        }

        [Test]
        public void ShouldHaveALongBow()
        {
            var sut=new PlayerCharacter();
            Assert.That(sut.Weapons, Contains.Item("Long Bow"));
        }
        [Test]
        public void ShouldHaveAtLeastOneKindOfSword()
        {
            var sut = new PlayerCharacter();
            Assert.That(sut.Weapons, Has.Some.ContainsSubstring("Sword"));
        }
        [Test]
        public void ShouldHaveTwoBows()
        {
            var sut = new PlayerCharacter();
            Assert.That(sut.Weapons, Has.Exactly(2).EndsWith("Bow"));
        }
        [Test]
        public void ShouldNotHaveMoreThanOneTypeOfAGivenWeapon()
        {
            var sut = new PlayerCharacter();
            Assert.That(sut.Weapons, Is.Unique);
        }
        [Test]
        public void ShouldNotHaveAStaffOfWonder()
        {
            var sut = new PlayerCharacter();
            Assert.That(sut.Weapons, Has.None.EqualTo("Staff Of Wonder"));
        }
        [Test]
        public void ShouldHaveAllExpectedWeapons()
        {
            var sut = new PlayerCharacter();
            var expectedWeapons = new[]
            {   
                "Long Bow",
                "Short Bow",
                "Short Sword"
            };
            Assert.That(sut.Weapons, Is.EquivalentTo(expectedWeapons));
        }
        [Test]
        public void ShouldHaveDefaultWeaponsInAlphabeticalOrder()
        {
            var sut = new PlayerCharacter();
           
            Assert.That(sut.Weapons, Is.Ordered);
        }

        [Test]
        public void ReferenceEqualityDemo()
        {
            var player1 = new PlayerCharacter();
            var player2 = new PlayerCharacter();
            var somePlayer = player1;
            Assert.That(somePlayer,Is.SameAs(player1));
        }




    }

}
