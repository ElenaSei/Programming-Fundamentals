using System;
using System.Collections.Generic;
using System.Linq;

namespace _07PopulationCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> populationCounter = new Dictionary<string, Dictionary<string, long>>();
            string input;

            while ((input = Console.ReadLine()) != "report")
            {
                string[] tokens = input.Split('|');
                string city = tokens[0];
                string country = tokens[1];
                long population = long.Parse(tokens[2]);

                if (!populationCounter.ContainsKey(country))
                {
                    populationCounter.Add(country, new Dictionary<string, long>());
                }
                populationCounter[country].Add(city, population);
            }

            foreach (var kvp in populationCounter.OrderByDescending(x => x.Value.Values.Sum()))
            {
                Console.WriteLine($"{kvp.Key} (total population: {kvp.Value.Values.Sum()})");
                foreach (var pair in kvp.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"=>{pair.Key}: {pair.Value}");
                }
            }
        }
    }
}
