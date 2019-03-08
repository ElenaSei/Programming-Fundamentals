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
            BigInteger totalWalk = secPerStep * steps;
            BigInteger departureInSec = departure.Hour * 3600 + departure.Minute * 60 + departure.Second;

            BigInteger reminder = totalWalk % 86400;
            int totalTimeSec = (int)departureInSec + (int)reminder;
            TimeSpan arrival = TimeSpan.FromSeconds(totalTimeSec);

            Console.WriteLine("Time Arrival: " + "{0:d2}:{1:d2}:{2:d2}", arrival.Hours, arrival.Minutes, arrival.Seconds);
        }
    }
}
