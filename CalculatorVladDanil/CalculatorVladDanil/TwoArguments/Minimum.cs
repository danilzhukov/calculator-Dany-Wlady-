using System;

namespace CalculatorVladDanil.TwoArguments
{
    public class Minimum : ITwoArgumentsCalculator
    {
        public double ExecuteOperation(double firstArgument, double secondArgument)
        {
            return Math.Min(firstArgument, secondArgument);
        }
    }
}
