using System;
using System.Collections.Generic;
using System.Linq;

namespace temp
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, SortedDictionary<string, int[]>> dragonArmy = new Dictionary<string, SortedDictionary<string, int[]>>();

            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                string[] tokens = Console.ReadLine().Split();
                string type = tokens[0];
                string name = tokens[1];

                if (!int.TryParse(tokens[2], out int damage))
                {
                    damage = 45;
                }
                if (!int.TryParse(tokens[3], out int health))
                {
                    health = 250;
                }
                if (!int.TryParse(tokens[4], out int armor))
                {
                    armor = 10;
                }

                if (!dragonArmy.ContainsKey(type))
                {
                    dragonArmy.Add(type, new SortedDictionary<string, int[]>());
                }
                if (!dragonArmy[type].ContainsKey(name))
                {
                    dragonArmy[type].Add(name, new int[3]);

                }

                dragonArmy[type][name][0] = damage;
                dragonArmy[type][name][1] = health;
                dragonArmy[type][name][2] = armor;
            }

            Dictionary<string, double[]> typeStats = new Dictionary<string, double[]>();

            foreach (var kvp in dragonArmy)
            {
                int numberOfDragons = kvp.Value.Count();
                string type = kvp.Key;
                typeStats.Add(type, new double[3]);

                foreach (var pair in kvp.Value)
                {
                    typeStats[type][0] += pair.Value[0];
                    typeStats[type][1] += pair.Value[1];
                    typeStats[type][2] += pair.Value[2];
                }
                double damage = typeStats[type][0] / numberOfDragons;
                double health = typeStats[type][1] / numberOfDragons;
                double armor = typeStats[type][2] / numberOfDragons;

                Console.WriteLine($"{type}::({damage:f2}/{health:f2}/{armor:f2})");

                foreach (var dragon in kvp.Value)
                {
                    Console.WriteLine($"-{dragon.Key} -> damage: {dragon.Value[0]}, health: {dragon.Value[1]}, armor: {dragon.Value[2]}");
                }
            }
        }
    }
}