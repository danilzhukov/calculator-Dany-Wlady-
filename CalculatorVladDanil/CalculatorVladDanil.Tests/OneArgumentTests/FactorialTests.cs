using CalculatorVladDanil.OneArgument;
using NUnit.Framework;

namespace CalculatorVladDanil.Tests.OneArgumentTests
{
    [TestFixture]
    public class FactorialTests
    {
        [TestCase(5, 120)]
        [TestCase(2, 2)]
        [TestCase(6, 720)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new Factorial();
            var actualResult = calculator.OneArgumentOperation(firstValue);
            Assert.AreEqual(expected, actualResult);
        }

    }
}
