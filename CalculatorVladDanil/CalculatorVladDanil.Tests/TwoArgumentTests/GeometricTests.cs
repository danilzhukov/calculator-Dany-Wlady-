using CalculatorVladDanil.TwoArguments;
using NUnit.Framework;

namespace CalculatorVladDanil.Tests.TwoArgumentTests
{
    [TestFixture]
    public class GeometricTests
    {
        [TestCase(0, 0, 0)]
        [TestCase(8, 8, 8)]
        [TestCase(10, 10, 10)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new Geometric();
            var actualResult = calculator.ExecuteOperation(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }

    }
    }