using System;

namespace CalculatorVladDanil.OneArgument
{
    public class ExponentiationFirstAr: IOneArgumentscalculator
    {
        public double OneArgumentOperation(double firstArgument)
        {
            return Math.Pow(2, firstArgument);
        }
    }
}
