using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTesting
{
    public class TemperatureConverter
    {
        public void farenheitToCelcius(double farenheit)
        { 
            double celcius = (farenheit - 32) * 5 / 9;
            Console.WriteLine(farenheit + " farenheit temperature in celcius is " + celcius);
        }
        public void celciusToFareheit(int celcius)
        {
            double farenheit = (celcius * 9 / 5) + 32 ;
            Console.WriteLine(celcius + " celcius temperature in farenheit is " +farenheit);
        }
        public void conversion()
        {
            Console.Write("1.Farenheit to degree\n2.degree to farenheit\nEnter your option to convert: ");
            int option = Convert.ToInt32(Console.ReadLine());
            TemperatureConverter temperatureConverter = new TemperatureConverter();
            switch (option)
            {
                case 1:
                    Console.Write("Enter temperature in Farenheit: ");
                    double farenheit = Convert.ToInt32(Console.ReadLine());
                    temperatureConverter.farenheitToCelcius(farenheit);
                    break;
                case 2:
                    Console.Write("Enter temperature in degree: ");
                    int celcius = Convert.ToInt32(Console.ReadLine());
                    temperatureConverter.celciusToFareheit(celcius);
                    break;
            }
        }
    }
}
