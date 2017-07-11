using System;

namespace CalculatorVladDanil
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
                default:
                    throw new Exception("Неизвестная операция");

            }
        }
    }
}
