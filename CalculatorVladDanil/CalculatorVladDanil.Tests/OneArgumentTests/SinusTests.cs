using CalculatorVladDanil.OneArgument;
using NUnit.Framework;

namespace CalculatorVladDanil.Tests.OneArgumentTests
{
    [TestFixture]
    public class SinusTests
    {
        [TestCase(0, 0)]
        [TestCase(0.10, 0.0998)]
        [TestCase(0.12, 0.1197)]
        public void CalculateTest(double firstValue,  double expected)
        {
            var calculator = new Sinus();
            var actualResult = calculator.OneArgumentOperation(firstValue);
            Assert.AreEqual(expected, actualResult, 0.0001);
        }

    }
}
