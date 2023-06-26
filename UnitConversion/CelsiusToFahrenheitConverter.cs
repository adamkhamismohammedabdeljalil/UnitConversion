using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConversion
{
    internal class CelsiusToFahrenheitConverter
    {
        public double TempInCelsius
        {
            get; set;   
        }
        public void Convert()
        {
            double result = 1.8 * TempInCelsius + 32;
            Console.WriteLine($"{TempInCelsius} °C in Fahrenheit is : {result} °F.");
        }
    }
}
