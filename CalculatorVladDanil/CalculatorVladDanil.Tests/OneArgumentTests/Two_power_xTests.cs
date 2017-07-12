using CalculatorVladDanil.OneArgument;
using NUnit.Framework;

namespace CalculatorVladDanil.Tests.OneArgumentTests
{
    [TestFixture]
    public class Two_power_xTests
    {
        [TestCase(1, 2)]
        [TestCase(2, 4)]
        [TestCase(3, 8)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new ExponentiationFirstAr();
            var actualResult = calculator.OneArgumentOperation(firstValue);
            Assert.AreEqual(expected, actualResult);
        }

    }
}
