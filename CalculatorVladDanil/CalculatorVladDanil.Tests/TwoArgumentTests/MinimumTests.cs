using CalculatorVladDanil.TwoArguments;
using NUnit.Framework;

namespace CalculatorVladDanil.Tests.TwoArgumentTests
{
    [TestFixture]
    public class MinimunTests
    {
        [TestCase(0, 0, 0)]
        [TestCase(4, 2, 2)]
        [TestCase(16, 4, 4)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new Minimum();
            var actualResult = calculator.ExecuteOperation(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }

    }
}