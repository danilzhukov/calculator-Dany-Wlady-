using CalculatorVladDanil.TwoArguments;
using NUnit.Framework;

namespace CalculatorVladDanil.Tests.TwoArgumentTests
{
    [TestFixture]
    public class MaximumTests
    {
        [TestCase(0, 0, 0)]
        [TestCase(4, 2, 4)]
        [TestCase(16, 4, 16)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new Maximum();
            var actualResult = calculator.ExecuteOperation(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }

    }
}