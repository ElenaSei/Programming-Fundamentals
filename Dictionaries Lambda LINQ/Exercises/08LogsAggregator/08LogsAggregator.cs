using System;
using System.Collections.Generic;
using System.Linq;

namespace _08LogsAggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            int line = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> nameIp = new Dictionary<string, List<string>>();
            Dictionary<string, int> nameDuration = new Dictionary<string, int>();

            for (int i = 0; i < line; i++)
            {
                string[] tokens = Console.ReadLine().Split();
                string ip = tokens[0];
                string name = tokens[1];
                int duration = int.Parse(tokens[2]);

                if (!nameIp.ContainsKey(name))
                {
                    nameIp.Add(name, new List<string>());
                    nameDuration.Add(name, 0);
                }
                if (!nameIp[name].Contains(ip))
                {
                    nameIp[name].Add(ip);
                }
                nameDuration[name] += duration;
            }

            foreach (var kvp in nameDuration.OrderBy(x => x.Key))
            {
                nameIp = nameIp.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
                string ips = string.Join(", ", nameIp[kvp.Key].OrderBy(x => x));

                Console.WriteLine($"{kvp.Key}: {kvp.Value} [{ips}]");
            }
        }
    }
}
