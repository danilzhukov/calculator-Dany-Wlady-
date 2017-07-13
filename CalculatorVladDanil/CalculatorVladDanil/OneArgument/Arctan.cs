using System;

namespace CalculatorVladDanil.OneArgument
{
    /// <summary>
    /// The class performs the mathematical function Arctan
    /// </summary>
    public class Arctan : IOneArgumentscalculator
    {
        public double OneArgumentOperation(double firstArgument)
        {
            return Math.Atan(firstArgument);
        }
    }
}
