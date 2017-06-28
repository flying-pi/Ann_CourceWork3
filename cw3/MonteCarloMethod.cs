using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw3
{
    class MonteCarloMethod:NumericMethod
    {
        private int _numCount = 1000;
        protected override double Calculate(Func<double, double> function)
        {
            double result = 0;
            Random rand = new Random();
            double distance = UpperAge - LowerAge;
            double x;
            for (int i = 0; i < _numCount; i++)
            {
                x = rand.NextDouble() * distance + LowerAge;
                result += function(x);
            }
            result = ((UpperAge - LowerAge) / _numCount) * result;
            return result;
        }
    }
}
