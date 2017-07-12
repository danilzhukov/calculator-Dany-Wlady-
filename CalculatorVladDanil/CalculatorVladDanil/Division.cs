namespace CalculatorVladDanil
{
    public class Division : ITwoArgumentsCalculator
    {
        public double ExecuteOperation(double firstArgument, double secondArgument)
        {
            return firstArgument / secondArgument;
        }
    }
}
