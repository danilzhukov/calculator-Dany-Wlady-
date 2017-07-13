using System;

namespace CalculatorVladDanil.OneArgument
{
    /// <summary>
    /// The class performs the mathematical function Arcsinus
    /// </summary>
    public class Arcsin: IOneArgumentscalculator
    {
        public double OneArgumentOperation(double firstArgument)
        {
            return Math.Asin(firstArgument);
        }
    }
}
