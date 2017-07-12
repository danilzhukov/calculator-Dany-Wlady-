using System;

namespace CalculatorVladDanil.OneArgument
{
    public class Log : IOneArgumentscalculator
    {
        public double OneArgumentOperation(double firstArgument)
        {
            if (firstArgument < 0)
            {
                throw new Exception("Число должно быть больше нуля");
            }
            return Math.Log(firstArgument);
        }
    }
}
