using System;

namespace _01CharityMarathon
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            long runners = long.Parse(Console.ReadLine());
            int averageLapsPerRunner = int.Parse(Console.ReadLine());
            long trackLength = long.Parse(Console.ReadLine());
            int trackCapacity = int.Parse(Console.ReadLine());
            double moneyPerKm = double.Parse(Console.ReadLine());

            if (days * trackCapacity < runners)
            {
                runners = days * trackCapacity;
            }

            long totalMeters = runners * averageLapsPerRunner * trackLength;
            double totalKm = totalMeters / 1000.0;
            double totalMoney = totalKm * moneyPerKm;

            Console.WriteLine($"Money raised: {totalMoney:f2}");
        }
    }
}
