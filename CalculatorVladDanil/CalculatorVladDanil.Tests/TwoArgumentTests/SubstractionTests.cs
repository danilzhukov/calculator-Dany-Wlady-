using CalculatorVladDanil.TwoArguments;
using NUnit.Framework;

namespace CalculatorVladDanil.Tests.TwoArgumentTests
{
    [TestFixture]
    public class SubstractionTests
    {
        [Test]
        public void SubstractionTest()
        {
            double first = 2;
            double second = 2;
            var calc = new Substraction();
            double result = calc.ExecuteOperation(first, second);
            Assert.AreEqual(0, result);
        }
    }
}
