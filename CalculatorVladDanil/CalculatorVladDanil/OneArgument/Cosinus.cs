using System;

namespace CalculatorVladDanil.OneArgument
{
    public class Cosinus : IOneArgumentscalculator
    {
        public double OneArgumentOperation(double firstArgument)
        {
            return Math.Cos(firstArgument);
        }
    }
}
