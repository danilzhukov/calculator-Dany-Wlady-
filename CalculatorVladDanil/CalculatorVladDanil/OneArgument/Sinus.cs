using System;

namespace CalculatorVladDanil.OneArgument
{
    public class Sinus : IOneArgumentscalculator
    {
        public double OneArgumentOperation(double firstArgument)
        {
            return Math.Sin(firstArgument);
        }
    }
}
