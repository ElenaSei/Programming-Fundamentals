using System;
using System.Numerics;

namespace _01Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfSnowballs = int.Parse(Console.ReadLine());

            BigInteger maxSnowballValue = 0;
            int bestSnow = 0;
            int bestTime = 1;
            double bestQuality = 0;
            for (int i = 0; i < numOfSnowballs; i++)
            {

                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                BigInteger snowballValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);

                if (snowballValue >= maxSnowballValue)
                {
                    maxSnowballValue = snowballValue;
                    bestSnow = snowballSnow;
                    bestTime = snowballTime;
                    bestQuality = snowballQuality;
                }

            }
            Console.WriteLine($"{bestSnow} : {bestTime} = {maxSnowballValue} ({bestQuality})");
        }
    }
}
