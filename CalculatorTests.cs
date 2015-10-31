using System;
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

        [Test]
        public void ShouldErrorWhenDivideZero()
        {
            var sut = new Calculator();
            Assert.That(() => sut.Divide(200, 0), Throws.Exception);
        }

        [Test]
        public void ShouldErrorWhenDivideZero_ExcplictExceptionTyped()
        {
            var sut = new Calculator();
            Assert.That(() => sut.Divide(99, 0), Throws.TypeOf<DivideByZeroException>());
        }


        [Test]
        public void ShouldErrorWhenNumberTooBig()
        {
            var sut = new Calculator();
            Assert.That(() => sut.Divide(200, 2), Throws.TypeOf<ArgumentOutOfRangeException>());
        }


        [Test]
        public void ShouldErrorWhenNumberTooBig_MoreExplicit()
        {
            var sut = new Calculator();
            Assert.That(() => sut.Divide(200, 2), Throws.TypeOf<ArgumentOutOfRangeException>().With.Matches<ArgumentOutOfRangeException>(x => x.ParamName == "value"));
        }


    }

    
}
