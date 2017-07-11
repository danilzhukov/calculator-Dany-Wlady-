namespace CalculatorVladDanil.TwoArguments
{
    public class Addition : ITwoArgumentsCalculator
    {
       public double ExecuteOperation(double firstArgument, double secondArgument)
         {
            return firstArgument + secondArgument;
         }
    }
}
