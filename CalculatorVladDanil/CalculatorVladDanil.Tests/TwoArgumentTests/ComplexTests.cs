using CalculatorVladDanil.TwoArguments;
using NUnit.Framework;

namespace CalculatorVladDanil.Tests.TwoArgumentTests
{
    [TestFixture]
    public class ComplexTests
    {
        [TestCase(1,1 ,1 )]
        [TestCase(4, 2, 2)]
        [TestCase(9, 2, 3)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new Complex();
            var actualResult = calculator.ExecuteOperation(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }

    }
}
