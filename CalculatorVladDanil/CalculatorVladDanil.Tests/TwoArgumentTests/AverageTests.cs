using CalculatorVladDanil.TwoArguments;
using NUnit.Framework;

namespace CalculatorVladDanil.Tests.TwoArgumentTests
{
    [TestFixture]
    public class AverageTests
    {
        [TestCase(0, 0, 0)]
        [TestCase(4, 4, 4)]
        [TestCase(16, 4, 10)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new Average();
            var actualResult = calculator.ExecuteOperation(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }

    }
}