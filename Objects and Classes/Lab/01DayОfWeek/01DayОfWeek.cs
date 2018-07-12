using System;
using System.Globalization;

namespace _01DayОfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string date = Console.ReadLine();
            DateTime dayOfWeek = DateTime.ParseExact(date, "d-M-yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine("{0}",dayOfWeek.DayOfWeek);
        }
    }
}
