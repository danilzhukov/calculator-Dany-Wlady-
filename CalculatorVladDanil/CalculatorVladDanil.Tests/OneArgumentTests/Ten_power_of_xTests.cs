using CalculatorVladDanil.OneArgument;
using NUnit.Framework;

namespace CalculatorVladDanil.Tests.OneArgumentTests
{
    [TestFixture]
    public class Ten_power_of_xTests
    {
        [TestCase(1, 10)]
        [TestCase(2, 100)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new Ten_pow_x();
            var actualResult = calculator.OneArgumentOperation(firstValue);
            Assert.AreEqual(expected, actualResult);
        }

    }
}
