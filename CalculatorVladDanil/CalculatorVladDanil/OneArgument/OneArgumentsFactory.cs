using System;

namespace CalculatorVladDanil.OneArgument
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
                case "buttonLn":
                    return new Log();
                case "buttonExp":
                    return new Exp();
                case "buttonX":
                    return new DivisionFirstAr();
                case "button2x":
                    return new ExponentiationFirstAr();
                case "buttonArcsin":
                    return new Arcsin();
                case "buttonArctan":
                    return new Arctan();
                default:
                    throw new Exception("Неизвестная операция");

            }
        }
    }
}
