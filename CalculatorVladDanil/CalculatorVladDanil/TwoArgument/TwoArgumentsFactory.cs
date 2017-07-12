using System;

namespace CalculatorVladDanil.TwoArgument
{
    public static class TwoArgumentsFactory
    {
        public static ITwoArgumentsCalculator CreateCalculator(string calculatorName)
        {
            switch (calculatorName)
            {
                case "buttonPlus":
                    return new Addition();
                case "buttonMinus":
                    return new Substraction();
                case "buttonMulti":
                    return new Multiplication();
                case "buttonDivision":
                    return new Division();
                case "buttonExponentiation":
                    return new Exponentiation();
                case "buttonXY":
                    return new Complex();
                default:
                    throw new Exception("Неизвестная операция");

            }
        }
    }
}
