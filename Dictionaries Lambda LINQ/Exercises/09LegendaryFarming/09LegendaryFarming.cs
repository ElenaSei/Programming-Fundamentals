using System;
using System.Collections.Generic;
using System.Linq;

namespace _09LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> junk = new Dictionary<string, int>();
            Dictionary<string, int> keyMaterials = new Dictionary<string, int>
            {
                {"shards", 0},
                {"fragments", 0},
                {"motes", 0}
            };
            string material = "";
            int value = 0;
            string legendaryItem = "";
            bool itemObtained = false;
            while (!itemObtained)
            {
                string[] input = Console.ReadLine().ToLower().Split(' ').ToArray();
                for (int i = 0; i < input.Length - 1; i++)
                {
                    value = int.Parse(input[i]);
                    material = input[i + 1];
                    if (keyMaterials.ContainsKey(material))
                    {
                        keyMaterials[material] += value;
                        if (keyMaterials[material] >= 250)
                        {
                            if (material == "shards")
                            {
                                legendaryItem = "Shadowmourne";
                            }
                            else if (material == "fragments")
                            {
                                legendaryItem = "Valanyr";
                            }
                            else
                            {
                                legendaryItem = "Dragonwrath";
                            }
                            keyMaterials[material] -= 250;
                            Console.WriteLine($"{legendaryItem} obtained!");
                            itemObtained = true;
                            break;
                        }
                    }
                    else
                    {
                        if (!junk.ContainsKey(material))
                        {
                            junk.Add(material, value);
                        }
                        else
                        {
                            junk[material] += value;
                        }
                    }
                    i++;
                }
            }

            foreach (var pair in keyMaterials.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
            foreach (var pair in junk.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
        }
    }
}
