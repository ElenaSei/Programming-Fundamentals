using System;
using System.Collections.Generic;
using System.Linq;

namespace _10СръбскоUnleashed
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> concerts = new Dictionary<string, Dictionary<string, long>>();

            bool wrongInput = false;
            string input;

            while ((input = Console.ReadLine())!= "End")
            {
                string singer = input.Split('@')[0];

                if (!singer.EndsWith(' '))
                {
                    wrongInput = true;
                    continue;
                }

                singer = singer.Trim();

                //what if we don't have @
                string[] tokens = input.Split('@')[1].Split(' ');

                if (tokens.Length < 3)
                {
                    wrongInput = true;
                    continue;
                }

                int lastIndex = -1;
                string venue = "";
                // what if we have more then 3 words?
                for (int i = 0; i < tokens.Length; i++)
                {
                    if (tokens[i].All(char.IsLetter))
                    {
                        venue += tokens[i] + " ";
                    }
                    else
                    {
                        lastIndex = i;
                        break;
                    }
                }

                venue = venue.Trim();

                if (string.IsNullOrEmpty(venue))
                {
                    wrongInput = true;
                    continue;
                }

                if (!int.TryParse(tokens[lastIndex], out int ticketPrice))
                {
                    wrongInput = true;
                    continue;
                }

                if (!int.TryParse(tokens[lastIndex + 1], out int ticketsCount))
                {
                    wrongInput = true;
                    continue;
                }

                if (!concerts.ContainsKey(venue))
                {
                    concerts.Add(venue, new Dictionary<string, long>());
                }

                long moneyEarned = (long)ticketsCount * ticketPrice;

                if (!concerts[venue].ContainsKey(singer))
                {
                    concerts[venue].Add(singer, 0);
                }
                concerts[venue][singer] += moneyEarned;
            }

            foreach (var kvp in concerts)
            {
                Console.WriteLine(kvp.Key);
                foreach (var pair in kvp.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {pair.Key} -> {pair.Value}");
                }
            }
        }
    }
}
