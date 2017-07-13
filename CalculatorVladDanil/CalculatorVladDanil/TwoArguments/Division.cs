using System;

namespace CalculatorVladDanil.TwoArguments
{
    public class Division : ITwoArgumentsCalculator
    {
        public double ExecuteOperation(double firstArgument, double secondArgument)
        {
            if (secondArgument == 0)
            {
                throw new Exception("Нельзя делить на ноль!");
            }
            return firstArgument / secondArgument;
        }
    }
}
