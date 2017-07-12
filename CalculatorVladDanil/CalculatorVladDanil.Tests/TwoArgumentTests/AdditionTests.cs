using CalculatorVladDanil.TwoArguments;
using NUnit.Framework;

namespace CalculatorVladDanil.Tests.TwoArgumentTests
{
   
        [TestFixture]
        public class AdditionTests
        {
            [Test]
            public void AdditionTest()
            {
                double first = 2;
                double second = 2;
            var calc=new Addition();
                double result = calc.ExecuteOperation(first,second);
                Assert.AreEqual(4, result);
            }
 
        }

    }
