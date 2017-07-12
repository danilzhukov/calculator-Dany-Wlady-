using System;

namespace CalculatorVladDanil.OneArgument
{
    public class Module_of_x : IOneArgumentscalculator
    {
        public double OneArgumentOperation(double firstArgument)
        {
            return Math.Sign(firstArgument);
        }
    }
}
