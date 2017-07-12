using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorVladDanil.TwoArguments
{
    public class Minimum : ITwoArgumentsCalculator
    {
        public double ExecuteOperation(double firstArgument, double secondArgument)
        {
            return Math.Min(firstArgument, secondArgument);
        }
    }
}
