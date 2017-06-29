using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw3
{
    class RectangleMethod : NumericMethod
    {

        protected override double Calculate(Func<double, double> function)
        {
            return function((UpperAge + LowerAge) / 2) * (UpperAge - LowerAge);
        }
    }
}