using System;

namespace CalculatorVladDanil
{
   public static class OneArgumentsFactory
    {
        public static IOneArgumentscalculator CreateCalculator(string calculatorName)
        {
            switch (calculatorName)
            {
                case "buttonSinus":
                    return new Sinus();
                case "buttonSquare":
                    return new SquareArgument();
                default:
                    throw new Exception("Неизвестная операция");

            }
        }
    }
}
