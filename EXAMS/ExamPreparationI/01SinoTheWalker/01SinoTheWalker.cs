using System;
using System.Globalization;
using System.Numerics;

namespace _01SinoTheWalker
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime departure = DateTime.ParseExact(Console.ReadLine(), "HH:mm:ss", CultureInfo.InvariantCulture);
            BigInteger steps = BigInteger.Parse(Console.ReadLine());
            BigInteger secPerStep = BigInteger.Parse(Console.ReadLine());

            BigInteger ArravalInSeconds = steps * secPerStep + (BigInteger)departure.Hour * 3600 + (BigInteger)departure.Minute * 60 + departure.Second;
            int secondsPerDay = (int)(ArravalInSeconds % 86400);
            TimeSpan arrival = TimeSpan.FromSeconds(secondsPerDay);
            Console.WriteLine($"Time Arrival: " + "{0:d2}:{1:d2}:{2:d2}", arrival.Hours, arrival.Minutes, arrival.Seconds);
        }
    }
}
