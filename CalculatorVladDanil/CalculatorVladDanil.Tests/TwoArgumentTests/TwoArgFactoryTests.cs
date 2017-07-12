using CalculatorVladDanil.OneArgument;
using NUnit.Framework;
using System;
using CalculatorVladDanil.TwoArguments;

namespace CalculatorVladDanil.Tests.TwoArgumentTests
{
    [TestFixture]
    public class TwoArgFactoryTests
    {
        [TestCase("Average", typeof(Average))]
        [TestCase("Maximum", typeof(Maximum))]

        public void CalculateTest(string name, Type type)
        {
            var calculator = TwoArgumentsFactory.CreateCalculator(name);

            Assert.IsInstanceOf(type, calculator);
        }

    }
}
