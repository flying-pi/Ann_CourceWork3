using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw3
{
    class GauseMethod : NumericMethod
    {
        private double[] x =
        {
            -0.9324700,
            -0.6612094,
            -0.2386142,
            0.2386142,
            0.6612094,
            0.9324700
        };

        private double[] w =
        {
            0.1713245,
            0.3607616,
            0.4679140,
            0.4679140,
            0.3607616,
            0.1713245
        };

        protected override double Calculate(Func<double, double> function)
        {
            double result = 0;
            for (int i = 0; i < x.Length; i++)
            {
                result += w[i] * function(FixX(x[i]));
            }
            result = ((UpperAge - LowerAge) / 2) * result;
            return result;
        }

        private double FixX(double x)
        {
            return ((UpperAge - LowerAge) / 2) * x + (UpperAge + LowerAge) / 2;
        }
    }
}