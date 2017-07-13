using System;

namespace CalculatorVladDanil.TwoArguments
{
    public class Maximum : ITwoArgumentsCalculator
    {
        public double ExecuteOperation(double firstArgument, double secondArgument)
        {
            return Math.Max(firstArgument, secondArgument);
        }
    }
}
