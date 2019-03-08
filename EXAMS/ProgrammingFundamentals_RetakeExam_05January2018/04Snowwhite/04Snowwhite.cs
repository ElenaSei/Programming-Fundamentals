using System;
using System.Collections.Generic;
using System.Linq;

namespace _04Snowwhite
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, int> dwarfs = new Dictionary<string, int>();
            Dictionary<string, int> colors = new Dictionary<string, int>();

            while (input != "Once upon a time")
            {
                string[] dwarf = input.Split(" <:> ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                string name = dwarf[0];
                string color = dwarf[1];
                int physics = int.Parse(dwarf[2]);
                string currentId = $"{name} <-> {color}";

                if (!dwarfs.ContainsKey(currentId))
                {
                    dwarfs.Add(currentId, physics);
                }
                else if (dwarfs[currentId] < physics)
                {
                    dwarfs[currentId] = physics;
                }

                input = Console.ReadLine();
            }

            foreach (var item in dwarfs)
            {
                string[] tokens = item.Key.Split(new string[] { " <-> " }, StringSplitOptions.RemoveEmptyEntries);
                string color = tokens[1];
                if (!colors.ContainsKey(color))
                {
                    colors.Add(color, 0);
                }
                colors[color]++;
            }

            var sortedDwarfs = dwarfs.OrderByDescending(x => x.Value)
                                     .ThenByDescending(x => colors[x.Key.Split(new string[] { " <-> " }, StringSplitOptions.RemoveEmptyEntries)[1]])
                                     .ToDictionary(x => x.Key, x => x.Value);


            foreach (var item in sortedDwarfs)
            {
                string name = item.Key.Split(new string[] { " <-> " }, StringSplitOptions.RemoveEmptyEntries)[0];
                string color = item.Key.Split(new string[] { " <-> " }, StringSplitOptions.RemoveEmptyEntries)[1];

                Console.WriteLine($"({color}) {name} <-> {item.Value}");
            }
        }
    }
}
