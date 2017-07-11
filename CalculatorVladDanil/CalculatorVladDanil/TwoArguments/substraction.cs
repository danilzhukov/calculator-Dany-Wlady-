namespace CalculatorVladDanil
{
    public class Substraction : ITwoArgumentsCalculator
    {
        public double ExecuteOperation(double firstArgument, double secondArgument)
        {
            return firstArgument - secondArgument;
        }
    }
}

