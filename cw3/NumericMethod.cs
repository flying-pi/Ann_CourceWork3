using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw3
{
    abstract class NumericMethod : INumericMethod
    {
        public double LowerAge { get; set; } = -1;
        public double UpperAge { get; set; } = 1;
        public double ErorValue { get; set; } = 0.001;

        public double ApplayTo(Func<double, double> function)
        {
            List<double> values = new List<double>()
            {
                ApplayWithCurring(function, 10),
                ApplayWithCurring(function, 20)
            };
            int last = 1;
            while (Math.Abs(values[last]-values[last-1])>ErorValue || last>10000)
            {
                last++;
                values.Add(ApplayWithCurring(function, (last+1)*10));
            }
            return values[last];

        }

        protected double ApplayWithCurring(Func<double, double> function, int cuttingCount)
        {
            if(cuttingCount<1)
                throw new Exception("cutting count must be bigger of 0");
            double result = 0;
            double originalA = LowerAge;
            double originalB = UpperAge;
            double step = (originalB - originalA) / cuttingCount;
            UpperAge = LowerAge;
            for (int i = 0; i < cuttingCount; i++)
            {
                UpperAge += step;
                result += Calculate(function);
                LowerAge += step;
            }
            LowerAge = originalA;
            UpperAge = originalB;
            return result;
        }

        protected abstract double Calculate(Func<double, double> function);
    }
}
/*
 		result	1.3651263356323284	double
		result	1.3422504224882779	double
		result	1.3286064853631587	double

 		
 */
