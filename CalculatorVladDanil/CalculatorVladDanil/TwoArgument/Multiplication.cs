namespace CalculatorVladDanil.TwoArgument
{
    public class Multiplication : ITwoArgumentsCalculator
    {
        public double ExecuteOperation(double firstArgument, double secondArgument)
        {
            return firstArgument * secondArgument;
        }
    }
}
