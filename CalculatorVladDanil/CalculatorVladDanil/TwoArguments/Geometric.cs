using System;

namespace CalculatorVladDanil.TwoArguments
{
    public class Geometric : ITwoArgumentsCalculator
    {
        public double ExecuteOperation(double firstArgument, double secondArgument)
        {
            double result;
            result = firstArgument * secondArgument;
            return Math.Sqrt(result);
        }
    }
}
