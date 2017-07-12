using System;
/// <summary>
/// Calculators factory for one argument
/// </summary>
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
                case "Cosinus":
                    return new Cosinus();
                case "arccosinus":
                    return new Arccosinus();
                case "sqrt_of_x":
                    return new sqrt_of_x();
                case "Ten_power_of_x":
                    return new Ten_pow_x();
                case "Module_of_x":
                    return new Module_of_x();
                case "Factorial":
                    return new Factorial();

                default:
                    throw new Exception("Неизвестная операция");

            }
        }
    }
}
