using System;

namespace _05TemperatureConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            double fahrenheit = double.Parse(Console.ReadLine());
            double celsium = FahrenheitToCelsium(fahrenheit);
            Console.WriteLine($"{celsium:f2}");
        }

        static double FahrenheitToCelsium(double number)
        {
            return (number - 32) * 5 / 9;
        }
    }
}
