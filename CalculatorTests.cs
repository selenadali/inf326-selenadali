using NUnit.Framework;

namespace Calculator.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void ShouldAddInts(){
            var sut = new Calculator();
            var result = sut.AddInts(1, 2);
            Assert.That(result, Is.EqualTo(3));
            //Assert.That(result, Is.EqualTo(3).Within(1).Percent);
            //Assert.That(result, Is.Positive);
        }
        [Test]
        public void ShouldAddDoubles()
        {
            var sut = new Calculator();
            var result = sut.AddDoubles(1.1, 2.2);
            Assert.That(result, Is.EqualTo(3.3).Within(0.1));
        }
    }

    
}
