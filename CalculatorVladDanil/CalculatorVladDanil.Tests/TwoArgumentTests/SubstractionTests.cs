﻿using CalculatorVladDanil.TwoArguments;
using NUnit.Framework;

namespace CalculatorVladDanil.Tests.TwoArgumentTests
{
    [TestFixture]
    public class SubstractionTests
    {
        [TestCase(5, 2, 3)]
        [TestCase(3, 1, 2)]
        [TestCase(12, 2, 10)]
        public void CalculateTest(double firstValue, double secondValue, double expected)
        {
            var calculator = new Substraction();
            var actualResult = calculator.ExecuteOperation(firstValue, secondValue);
            Assert.AreEqual(expected, actualResult);
        }

    }
}


