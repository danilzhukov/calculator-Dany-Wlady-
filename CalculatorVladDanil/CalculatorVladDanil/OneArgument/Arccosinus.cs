using System;
using System.Collections.Specialized;

namespace CalculatorVladDanil.OneArgument
{
    public class Arccosinus : IOneArgumentscalculator
    {
        public double OneArgumentOperation(double firstArgument)
        {
            if (firstArgument > 1 || firstArgument < -1)
            {
                throw new Exception("Выход за границы функции");
            }
            return Math.Acos(firstArgument);
        }
    }
}
