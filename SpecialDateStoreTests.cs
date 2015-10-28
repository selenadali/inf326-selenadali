using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SpecialDateStore;
using SpecialDateStore = SpecialDateStore.SpecialDateStore;

namespace SpecialDateStoreTests
{
    [TestFixture]
    public class SpecialDateStoreTests
    {
        [Test]
        public void ShouldHaveCorrectMilleniumDate()
        {
            var sut = new SpecialDateStore();
            var result = sut.DateOf(SpecialDates.NewMillennium);
            Assert.That(result, Is.EqualTo(new DateTime(2000,1,1,0,0,0,0)));
        }

        [Test]
        public void ShouldHaveCorrectMillenniumDate_WithTolerance()
        {
            var sut = new SpecialDateStore();
            var result = sut.DateOf(SpecialDateStoreTests.NewMillennium);
            Assert.That(result, Is.EqualTo(new DateTime(2000, 1, 1, 0, 0, 0, 1)));

            //Assert.That(result, Is.EqualTo(new DateTime(2000,1,1,0,0,0,1)).Within(TimeSpan.FromMilliseconds(1)));

            //Assert.That(result, Is.EqualTo(new DateTime(2000,1,1,0,0,0,0)).Within(1).Milliseconds);
  
        }
    }
}
