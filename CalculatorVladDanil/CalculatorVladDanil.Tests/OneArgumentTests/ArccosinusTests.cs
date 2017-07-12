using System;
using CalculatorVladDanil.OneArgument;
using NUnit.Framework;
/// <summary>
/// The class performs Arccosinus function testing
/// </summary>
namespace CalculatorVladDanil.Tests.OneArgumentTests
{
    [TestFixture]
    public class ArccosinnusTests
    {
        [TestCase(1, 0)]
        public void CalculateTest(double firstValue, double expected)
        {
            var calculator = new Arccosinus();
            var actualResult = calculator.OneArgumentOperation(firstValue);
            Assert.AreEqual(expected, actualResult);
        }

        [Test]
        public void ErrorTest()
        {
            var calculator = new Arccosinus();
            Assert.Throws<Exception>(() => calculator.OneArgumentOperation(5));
        }
    }
   
}
