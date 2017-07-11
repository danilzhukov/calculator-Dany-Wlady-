using System;

namespace CalculatorVladDanil.OneArgument
{
    public class Log : IOneArgumentscalculator
    {
        public double OneArgumentOperation(double firstArgument)
        {
            return Math.Log(firstArgument);
        }
    }
}
