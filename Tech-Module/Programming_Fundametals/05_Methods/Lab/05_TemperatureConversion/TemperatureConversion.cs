namespace _5.TemperatureConversion
{
    using System;

    public class TemperatureConversion
    {
        public static void Main()
        {
            var fahrenheit = double.Parse(Console.ReadLine());
            var celsius = FahrenheitToCelsius(fahrenheit);
            Console.WriteLine("{0:f2}", celsius);
        }

        public static double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
    }
}