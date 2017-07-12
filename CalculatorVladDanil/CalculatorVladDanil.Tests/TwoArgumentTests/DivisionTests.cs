using CalculatorVladDanil.TwoArguments;
using NUnit.Framework;

namespace CalculatorVladDanil.Tests.TwoArgumentTests
{
    [TestFixture]
    public class DivisionTests
    {
        [Test]
        public void DivisionTest()
        {
            double first = 2;
            double second = 2;
            var calc = new Division();
            double result = calc.ExecuteOperation(first, second);
            Assert.AreEqual(1, result);
        }
    }
}