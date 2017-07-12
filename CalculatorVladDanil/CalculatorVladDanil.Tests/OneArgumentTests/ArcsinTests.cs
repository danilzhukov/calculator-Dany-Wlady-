using CalculatorVladDanil.OneArgument;
using NUnit.Framework;

namespace CalculatorVladDanil.Tests.OneArgumentTests
{
    [TestFixture]
    public class ArcsinTests
    {
        [TestCase(0.5,0.523 )]
        [TestCase(1,1.571 )]
        [TestCase(0.1,0.100 )]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new Arcsin();
            var actualResult = calculator.OneArgumentOperation(firstValue);
            Assert.AreEqual(expected, actualResult, 0.001);
        }

    }
}
