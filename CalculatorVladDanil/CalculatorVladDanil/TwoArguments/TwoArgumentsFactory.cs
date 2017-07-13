using System;

namespace CalculatorVladDanil.TwoArguments
{
    /// <summary>
    /// Factory for two argument functions
    /// </summary>
    public static class TwoArgumentsFactory
    {
        /// <summary>
        /// Method for creating instance of class
        /// </summary>
        /// <param name="calculatorName">Input button name</param>
        /// <returns>Instance of class</returns>
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
                case "Maximum":
                    return new Maximum();
                case "Minimum":
                    return new Minimum();
                case "Average":
                    return new Average();
                case "Geometric":
                    return new Geometric();
                default:
                    throw new Exception("Неизвестная операция");

            }
        }
    }
}
