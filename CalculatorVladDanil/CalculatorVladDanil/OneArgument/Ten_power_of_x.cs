using System;

namespace CalculatorVladDanil.OneArgument
{
    public class Ten_pow_x : IOneArgumentscalculator
    {
        public double OneArgumentOperation(double firstArgument)
        {
            return Math.Pow(10, firstArgument);
        }
    }
}
