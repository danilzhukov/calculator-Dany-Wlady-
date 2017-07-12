using CalculatorVladDanil.TwoArguments;
using NUnit.Framework;

namespace CalculatorVladDanil.Tests.TwoArgumentTests
{
    [TestFixture]
    public class MultiplicationTests
    {
        [Test]
        public void MultiplicationTest()
        {
            double first = 2;
            double second = 2;
            var calc = new Multiplication();
            double result = calc.ExecuteOperation(first, second);
            Assert.AreEqual(4, result);
        }
    }
}
