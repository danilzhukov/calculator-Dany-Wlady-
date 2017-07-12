using System;
/// <summary>
/// The class performs the mathematical function Arcsinus
/// </summary>
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
