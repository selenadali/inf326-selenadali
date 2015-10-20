
using NUnit.Framework;

namespace Calculator.Tests
{
    [TestFixture]
    public class SimpleCalculatorTests
    {
        [Test]
        public void ShoulAddTwoNumbers()
        {
            var sut = new SimpleCalculator();

            var result = sut.Add(1, 2);

            Assert.That(result, Is.EqualTo(3));

        }
        [Test]
        public void ShoulMultiplyTwoNumbers()
        {
            var sut = new SimpleCalculator();

            var result = sut.Multiply(2, 10);

            Assert.That(result, Is.EqualTo(20));

        }
    }
}

