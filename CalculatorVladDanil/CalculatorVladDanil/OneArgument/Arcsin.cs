using System;

namespace CalculatorVladDanil.OneArgument
{
   public class Arcsin: IOneArgumentscalculator
    {
        public double OneArgumentOperation(double firstArgument)
        {
            return Math.Asin(firstArgument);
        }
    }
}
