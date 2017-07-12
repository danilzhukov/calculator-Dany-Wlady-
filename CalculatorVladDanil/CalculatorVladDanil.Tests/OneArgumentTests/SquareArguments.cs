using CalculatorVladDanil.OneArgument;
using NUnit.Framework;

namespace CalculatorVladDanil.Tests.OneArgumentTests
{
    [TestFixture]
    public class SquareArgumentTests
    {
        [TestCase(0, 0)]
        [TestCase(2, 4)]
        [TestCase(4, 16)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new SquareArgument();
            var actualResult = calculator.OneArgumentOperation(firstValue);
            Assert.AreEqual(expected, actualResult, 0.0001);
        }

    }
}
