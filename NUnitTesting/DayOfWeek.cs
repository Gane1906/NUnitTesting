using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTesting
{
    public class DayOfWeek
    {
        public void day(int m,int d,int y)
        {
            int year = y - (14 - m) / 12;
            int variable = year + (year / 4) - (year % 100) + (year % 400);
            int month = m + 12 * ((14 - m) / 12) - 2;
            int day = (d + variable + (31 * month) / 12) % 7;
            switch (day)
            {
                case 0:
                    Console.WriteLine("Sunday");
                    break;
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;

            }
        }
    }
}
