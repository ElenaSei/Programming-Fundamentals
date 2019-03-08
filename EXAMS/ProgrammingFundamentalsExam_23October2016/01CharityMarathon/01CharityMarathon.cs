using System;

namespace _01CharityMarathon
{
    class Program
    {
        static void Main(string[] args)
        {
            int marathonDays = int.Parse(Console.ReadLine());
            int runners = int.Parse(Console.ReadLine());
            int avarageLaps = int.Parse(Console.ReadLine());
            long trackLength = long.Parse(Console.ReadLine());
            int trackCapacity = int.Parse(Console.ReadLine());
            double moneyPerKm = double.Parse(Console.ReadLine());

            int maxRunners = trackCapacity * marathonDays;
            if (runners > maxRunners)
            {
                runners = maxRunners;
            }
            // try with long
            long totalMeters = runners * avarageLaps * trackLength;
            // try double
            double totalKm = totalMeters / 1000;
            double totalMoney = moneyPerKm * totalKm;
            Console.WriteLine($"Money raised: {totalMoney:f2}");
        }
    }
}
