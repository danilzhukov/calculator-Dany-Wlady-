using System;

namespace CalculatorVladDanil.OneArgument
{
    public class Exp: IOneArgumentscalculator
    {
        public double OneArgumentOperation(double firstArgument)
        {
            return Math.Exp(firstArgument);
        }
    }
}
