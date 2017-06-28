using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw3
{
    interface INumericMethod
    {
        double LowerAge { get; set; }
        double UpperAge { get; set; }
        double ErorValue { get; set; }
        double ApplayTo(Func<double, double> function);
    }
}
