using CalculatorVladDanil.TwoArguments;
using NUnit.Framework;

namespace CalculatorVladDanil.Tests.TwoArgumentTests
{
    [TestFixture]
    public class SquareArgumentTests
    {
        [TestCase(2, 3, 8)]
        [TestCase(3, 2, 9)]
        [TestCase(4, 2, 16)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new Exponentiation();
            var actualResult = calculator.ExecuteOperation(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }

    }
}
