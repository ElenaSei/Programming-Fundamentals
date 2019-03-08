using System;
using System.Collections.Generic;
using System.Linq;

namespace _04HornetArmada
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, long> legionActivity = new Dictionary<string, long>();
            Dictionary<string, Dictionary<string, long>> legionTypeCount = new Dictionary<string, Dictionary<string, long>>();


            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" =->:".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                long lastActivity = long.Parse(input[0]);
                string legionName = input[1];
                string soldierType = input[2];
                long soldierCount = long.Parse(input[3]);

                if (!legionActivity.ContainsKey(legionName))
                {
                    legionActivity.Add(legionName, 0);
                    legionTypeCount.Add(legionName, new Dictionary<string, long>());
                }
                if (legionActivity[legionName] < lastActivity)
                {
                    legionActivity[legionName] = lastActivity;
                }
                if (!legionTypeCount[legionName].ContainsKey(soldierType))
                {
                    legionTypeCount[legionName].Add(soldierType, 0);
                }
                legionTypeCount[legionName][soldierType] += soldierCount;
            }

            string[] commands = Console.ReadLine().Split('\\');

            if (commands.Length > 1)
            {
                long currentActivity = long.Parse(commands[0]);
                string currentType = commands[1];
                Dictionary<string, long> sorted = new Dictionary<string, long>();

                foreach (var kvp in legionActivity.Where(x => x.Value < currentActivity))
                {
                    if (legionTypeCount[kvp.Key].ContainsKey(currentType))
                    {
                        sorted.Add(kvp.Key, legionTypeCount[kvp.Key][currentType]);
                    }
                }
                foreach (var item in sorted.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"{item.Key} -> {item.Value}");
                }
            }
            else
            {
                string currentType = commands[0];
                Dictionary<string, long> sorted = new Dictionary<string, long>();

                foreach (var item in legionTypeCount.Where(x => x.Value.ContainsKey(currentType)))
                {
                    sorted.Add(item.Key, legionActivity[item.Key]);
                }

                foreach (var kvp in sorted.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"{kvp.Value} : {kvp.Key}");
                }
            }
        }
    }
}
