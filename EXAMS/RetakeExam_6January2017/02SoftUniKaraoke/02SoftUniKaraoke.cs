using System;
using System.Collections.Generic;
using System.Linq;

namespace _02SoftUniKaraoke
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] participants = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            string[] songs = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, List<string>> participantsAwards = new Dictionary<string, List<string>>();

            string input;
            while ((input = Console.ReadLine())!= "dawn")
            {
                string[] tokens = input.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
                string name = tokens[0];
                string song = tokens[1];
                string award = tokens[2];

                if (participants.Contains(name) && songs.Contains(song))
                {
                    if (!participantsAwards.ContainsKey(name))
                    {
                        participantsAwards.Add(name, new List<string>());
                    }
                    if (!participantsAwards[name].Contains(award))
                    {
                        participantsAwards[name].Add(award);
                    }
                }
            }
            if (participantsAwards.Count == 0)
            {
                Console.WriteLine("No awards");
            }

            foreach (var kvp in participantsAwards.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Count} awards");
                foreach (var award in kvp.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"--{award}");
                }
            }
        }
    }
}
