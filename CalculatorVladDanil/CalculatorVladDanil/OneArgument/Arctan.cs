using System;

namespace CalculatorVladDanil.OneArgument
{
    public class Arctan : IOneArgumentscalculator
    {
        public double OneArgumentOperation(double firstArgument)
        {
            return Math.Atan(firstArgument);
        }
    }
}
