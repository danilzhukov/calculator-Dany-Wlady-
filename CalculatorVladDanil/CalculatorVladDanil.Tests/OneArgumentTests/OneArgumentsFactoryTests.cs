using System;
using CalculatorVladDanil.OneArgument;
using NUnit.Framework;
/// <summary>
/// The class performs a testing of the calculator factory for one argument
/// </summary>
namespace CalculatorVladDanil.Tests.OneArgumentTests
{
    [TestFixture]
    public class OneArgumentsFactoryTests
    {
        [TestCase("buttonSinus", typeof(Sinus))]
        [TestCase("buttonSquare", typeof(SquareArgument))]

        public void CalculateTest(string name, Type type)
        {
            var calculator = OneArgumentsFactory.CreateCalculator(name);

            Assert.IsInstanceOf(type, calculator);
        }

    }
}
