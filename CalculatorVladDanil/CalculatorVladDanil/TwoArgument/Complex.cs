using System;

namespace CalculatorVladDanil.TwoArgument
{
    public class Complex : ITwoArgumentsCalculator
    {
        public double ExecuteOperation(double firstArgument, double secondArgument)
        {
            return Math.Pow(firstArgument, 1 / secondArgument);
        }
    }
}
