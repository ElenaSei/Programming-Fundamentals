﻿using System;
using System.Linq;

namespace _03EnduranceRally
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] drivers = Console.ReadLine().Split();
            double[] track = Console.ReadLine().Split().Select(double.Parse).ToArray();

            int[] checkpoint = Console.ReadLine().Split().Select(int.Parse).ToArray();

            foreach (var driver in drivers)
            {
                double fuel = driver[0];

                for (int i = 0; i < track.Length; i++)
                {
                    if (checkpoint.Any(x => x.Equals(i)))
                    {
                        fuel += track[i];
                    }
                    else
                    {
                        fuel -= track[i];
                    }
                    if (fuel <= 0)
                    {
                        Console.WriteLine($"{driver} - reached {i}");
                        break;
                    }
                }
                if (fuel > 0)
                {
                    Console.WriteLine($"{driver} - fuel left {fuel:f2}");
                }
            }
        }
    }
}
