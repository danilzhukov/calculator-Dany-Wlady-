using System;
/// <summary>
/// The class performs the mathematical function Arctan
/// </summary>
namespace CalculatorVladDanil.OneArgument
{
    public class Arctan : IOneArgumentscalculator
    {
        public double OneArgumentOperation(double firstArgument)
        {
            return Math.Atan(firstArgument);
        }
    }
}
