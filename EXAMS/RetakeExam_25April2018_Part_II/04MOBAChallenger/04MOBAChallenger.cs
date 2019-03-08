using System;
using System.Collections.Generic;
using System.Linq;

namespace _04MOBAChallenger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> playersStats = new Dictionary<string, Dictionary<string, int>>();

            string input;
            while ((input = Console.ReadLine()) != "Season end")
            {
                string[] tokens = input.Split(new string[] { " -> ", " vs " }, StringSplitOptions.RemoveEmptyEntries);

                if (tokens.Length == 3)
                {
                    string player = tokens[0];
                    string position = tokens[1];
                    int skill = int.Parse(tokens[2]);

                    if (!playersStats.ContainsKey(player))
                    {
                        playersStats.Add(player, new Dictionary<string, int>());
                    }
                    if (!playersStats[player].ContainsKey(position))
                    {
                        playersStats[player].Add(position, 0);
                    }
                    if (playersStats[player][position] < skill)
                    {
                        playersStats[player][position] = skill;
                    }
                }
                else if (tokens.Length == 2)
                {
                    string player1 = tokens[0];
                    string player2 = tokens[1];

                    if (playersStats.ContainsKey(player1) && playersStats.ContainsKey(player2))
                    {
                        foreach (var position in playersStats[player1])
                        {
                            if (playersStats[player2].ContainsKey(position.Key))
                            {
                                if (playersStats[player1][position.Key] > playersStats[player2][position.Key])
                                {
                                    playersStats.Remove(player2);
                                }
                                else if (playersStats[player1][position.Key] < playersStats[player2][position.Key])
                                {
                                    playersStats.Remove(player1);
                                }
                                break;
                            }
                        }
                    }
                }
            }
            foreach (var player in playersStats.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{player.Key}: {player.Value.Values.Sum()} skill");

                foreach (var kvp in player.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"- {kvp.Key} <::> {kvp.Value}");
                }
            }
        }
    }
}
