using System;

namespace CalculatorVladDanil.OneArgument
{
    public class sqrt_of_x : IOneArgumentscalculator
    {
        public double OneArgumentOperation(double firstArgument)
        {
            if (firstArgument < 0)
            {
                throw new Exception("Число должно быть больше нуля");
            }
            return Math.Pow(firstArgument,0.5);
        }
    }
}
