using CalculatorVladDanil.OneArgument;
using NUnit.Framework;

namespace CalculatorVladDanil.Tests.OneArgumentTests
{
    [TestFixture]
    public class Module_o_xfTests
    {
        [TestCase(6, 1)]
        [TestCase(5, 1)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new Module_of_x();
            var actualResult = calculator.OneArgumentOperation(firstValue);
            Assert.AreEqual(expected, actualResult);
        }

    }
}
