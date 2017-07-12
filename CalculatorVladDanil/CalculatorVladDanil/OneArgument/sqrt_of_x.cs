using System;

namespace CalculatorVladDanil.OneArgument
{
    public class sqrt_of_x : IOneArgumentscalculator
    {
        public double OneArgumentOperation(double firstArgument)
        {
            return Math.Pow(firstArgument,0.5);
        }
    }
}
