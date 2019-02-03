using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Calculator.Test.Unit
{
    [TestFixture]
    public class CalculatorUnitTest
    {
        // Brug af TestCase til at kunne teste mange forskellige inputs
        [TestCase(2, 4, 6)]
        [TestCase(-2,4,2)]
        public void Add_AddPosAndNegNumbers_AdditionsCorrect(double a, double b, double equalTo )
        {
            var uut = new Calculator();

            Assert.That(uut.Add(a, b), Is.EqualTo(equalTo));
        }

        [Test]
        public void Subtract_Subtract4And2_Returns2()
        {
            var uut = new Calculator();

            Assert.That(uut.Subtract(4, 2), Is.EqualTo(2));
        }
        [Test]
        public void Subtract_Subtract4AndMinus2_Returns6()
        {
            var uut = new Calculator();

            Assert.That(uut.Subtract(4, -2), Is.EqualTo(6));
        }
        [Test]
        public void Multiply_Multiply4And2_Returns8()
        {
            var uut = new Calculator();

            Assert.That(uut.Multiply(4, 2), Is.EqualTo(8));
        }
        [Test]
        public void Multiply_Multiply4AndMinus2_ReturnsMinus8()
        {
            var uut = new Calculator();

            Assert.That(uut.Multiply(4, -2), Is.EqualTo(-8));
        }

        [Test]
        public void Power_PowerOf5and3_Returns125()
        {
            var uut = new Calculator();

            Assert.That(uut.Power(5,3), Is.EqualTo(125));
        }

    /*    [Test]
        public void Power_PowerOf5AndMinus2_Returns0Dot04()
        {
            var uut = new Calculator();

            Assert.That(uut.Power(5,-2), Is.EqualTo(0.04));
        }*/
    }
}
