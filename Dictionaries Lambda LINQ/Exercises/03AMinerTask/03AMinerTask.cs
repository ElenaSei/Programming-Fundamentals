using System;
using System.Collections.Generic;
using System.Linq;

namespace _03AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resources = new Dictionary<string, int>();
            string input = Console.ReadLine();
            string metal = "";
            int quantity = 0;

            while (input != "stop")
            {
                metal = input;
                quantity = int.Parse(Console.ReadLine());
                if (!resources.ContainsKey(metal))
                {
                    resources.Add(metal, quantity);
                }
                else
                {
                    resources[metal] += quantity;
                }
                input = Console.ReadLine();
            }
            foreach (var pair in resources)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
