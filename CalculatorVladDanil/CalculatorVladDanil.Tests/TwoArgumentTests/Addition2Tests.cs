using CalculatorVladDanil.TwoArguments;
using NUnit.Framework;

namespace CalculatorVladDanil.Tests.TwoArgumentTests
{
   [TestFixture]
    public class Addition2Tests
    {
        [TestCase(0, 0, 0)]
        [TestCase(3, 4, 7)]
        [TestCase(-7, -2, -9)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
            {
                var calculator = new Addition();
                var actualResult = calculator.ExecuteOperation(firstValue, secondValue);
                Assert.AreEqual(expected, actualResult);
            }

       }
}
