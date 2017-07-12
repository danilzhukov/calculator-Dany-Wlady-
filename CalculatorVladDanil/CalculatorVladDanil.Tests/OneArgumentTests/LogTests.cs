using System;
using CalculatorVladDanil.OneArgument;
using NUnit.Framework;

namespace CalculatorVladDanil.Tests.OneArgumentTests
{
    [TestFixture]
    public class LogTests
    {
        [TestCase(1, 0)]
        [TestCase(2, 0.6931)]
        [TestCase(3, 1.0986)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new Log();
            var actualResult = calculator.OneArgumentOperation(firstValue);
            Assert.AreEqual(expected, actualResult, 0.0001);
        }
        [Test]
        public void ErrorTest()
        {
            var calculator = new Log();
            Assert.Throws<Exception>(() => calculator.OneArgumentOperation(-5));
        }
    }
}
