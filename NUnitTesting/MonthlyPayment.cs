using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTesting
{
    public class MonthlyPayment
    {
        public void calculatePayment(int principal,int year,int rateOfIntrest)
        {
            double rate = (rateOfIntrest / 12) * 100;
            double n = 12 * year;
            double payment = (principal * rateOfIntrest) / (1 - Math.Pow((1 + rateOfIntrest), -n));
            Console.WriteLine("Monthly payment is " + payment);
        }
    }
}
