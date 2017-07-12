using System;

namespace CalculatorVladDanil.OneArgument
{
    public class Arccosinus : IOneArgumentscalculator
    {
        public double OneArgumentOperation(double firstArgument)
        {
            return Math.Acos(firstArgument);
        }
    }
}
