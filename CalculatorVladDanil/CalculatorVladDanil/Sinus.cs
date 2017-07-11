using System;

namespace CalculatorVladDanil
{
    public class Sinus : IOneArgumentscalculator
    {
        public double OneArgumentOperation(double firstArgument)
        {
            return Math.Sin(firstArgument);
        }
    }
}
