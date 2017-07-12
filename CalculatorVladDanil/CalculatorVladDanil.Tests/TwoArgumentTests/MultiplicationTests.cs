using CalculatorVladDanil.TwoArguments;
using NUnit.Framework;

namespace CalculatorVladDanil.Tests.TwoArgumentTests
{
    [TestFixture]
    public class MultiplicationTests
    {
        [TestCase(2, 2, 4)]
        [TestCase(3, 4, 12)]
        [TestCase(5, 5, 25)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new Multiplication();
            var actualResult = calculator.ExecuteOperation(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }

    }
}

