using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTesting
{
    public class SquareRoot
    {
        const double EPSILON = 3.059;
        public void calculateRoot(int c)
        {
            double t = c;

            while (Math.Abs(t - c / t) > 1e-15 * t)
            {
                t = (c / t + t) / 2.0;
            }
            Console.WriteLine("The sq rot of "+c+" is: "+t);

        }
    }
}
