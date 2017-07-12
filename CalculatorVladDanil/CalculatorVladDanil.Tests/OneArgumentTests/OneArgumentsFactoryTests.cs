using System;
using CalculatorVladDanil.OneArgument;
using CalculatorVladDanil.TwoArguments;
using NUnit.Framework;

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
