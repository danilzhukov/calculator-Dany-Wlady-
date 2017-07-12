using CalculatorVladDanil.OneArgument;
using NUnit.Framework;

namespace CalculatorVladDanil.Tests.OneArgumentTests
{
    [TestFixture]
    public class ExpTests
    {
        [TestCase(1, 2.7)]
        [TestCase(2, 7.4)]
        [TestCase(3, 20.1)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new Exp();
            var actualResult = calculator.OneArgumentOperation(firstValue);
            Assert.AreEqual(expected, actualResult, 0.1);
        }

    }
}
