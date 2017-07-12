using System;

namespace CalculatorVladDanil.TwoArguments
{
    public class Average : ITwoArgumentsCalculator
    {
        public double ExecuteOperation(double firstArgument, double secondArgument)
        {

            return ((firstArgument + secondArgument) / 2);
        }
    }
}
