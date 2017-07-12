using CalculatorVladDanil.OneArgument;
using NUnit.Framework;

namespace CalculatorVladDanil.Tests.OneArgumentTests
{
    [TestFixture]
    public class ArctanTests
    {
        [TestCase(0.1, 0.0996)]
        [TestCase(0.5, 0.4636)]
        [TestCase(1, 0.7854)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new Arctan();
            var actualResult = calculator.OneArgumentOperation(firstValue);
            Assert.AreEqual(expected, actualResult, 0.0001);
        }

    }
}
