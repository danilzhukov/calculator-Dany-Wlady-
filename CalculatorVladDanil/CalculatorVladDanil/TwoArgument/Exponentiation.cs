using System;

namespace CalculatorVladDanil.TwoArgument
{
    public class Exponentiation : ITwoArgumentsCalculator
    {
        public double ExecuteOperation(double firstArgument, double secondArgument)
        {
            return Math.Pow(firstArgument, secondArgument);
        }
    }
}