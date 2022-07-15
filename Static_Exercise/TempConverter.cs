using System;
namespace Static_Exercise
{
  public static class TempConverter
  {

        // Methods

        public static double FahrenheitToCelsius(double fahrenheit)
        {
            var Celsius = (fahrenheit - 32) / 1.8;
            return Celsius;
        }

        public static double CelsiusToFahrenheit(double Celsius)
        {
            var Fahrenheit = (Celsius + 32) * 1.8;
            return Fahrenheit;
        }
  }
}

