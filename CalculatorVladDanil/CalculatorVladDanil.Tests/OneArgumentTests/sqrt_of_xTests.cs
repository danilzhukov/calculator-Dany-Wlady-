using System;
using CalculatorVladDanil.OneArgument;
using NUnit.Framework;

namespace CalculatorVladDanil.Tests.OneArgumentTests
{
    [TestFixture]
    public class sqrt_of_xTests
    {
        [TestCase(100, 10)]
        [TestCase(36, 6)]
        [TestCase(4, 2)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new sqrt_of_x();
            var actualResult = calculator.OneArgumentOperation(firstValue);
            Assert.AreEqual(expected, actualResult);
        }
        [Test]
        public void ErrorTest()
        {
            var calculator = new sqrt_of_x();
            Assert.Throws<Exception>(() => calculator.OneArgumentOperation(-5));
        }
    }
}
