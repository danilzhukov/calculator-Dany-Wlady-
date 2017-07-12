using CalculatorVladDanil.OneArgument;
using NUnit.Framework;

namespace CalculatorVladDanil.Tests.OneArgumentTests
{
    [TestFixture]
    public class DivisionArgTests
    {
        [TestCase(1, 1)]
        [TestCase(2, 0.5)]
        [TestCase(4, 0.25)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new DivisionFirstAr();
            var actualResult = calculator.OneArgumentOperation(firstValue);
            Assert.AreEqual(expected, actualResult, 0.0001);
        }

    }
}
