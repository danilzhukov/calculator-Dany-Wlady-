using CalculatorVladDanil.OneArgument;
using NUnit.Framework;
namespace CalculatorVladDanil.Tests.OneArgumentTests
{
    [TestFixture]
    public class CosinusTests
    {
        [TestCase(0, 1)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new Cosinus();
            var actualResult = calculator.OneArgumentOperation(firstValue);
            Assert.AreEqual(expected, actualResult);
        }

    }
}
