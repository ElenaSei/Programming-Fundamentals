using System;
using System.Collections.Generic;
using System.Linq;

namespace _03TseamAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> games = Console.ReadLine().Split().ToList();

            string input;
            while ((input = Console.ReadLine()) != "Play!")
            {
                string[] tokens = input.Split();
                string command = tokens[0];
                string game = tokens[1];

                switch (command)
                {
                    case "Install":
                        if (!games.Contains(game))
                        {
                            games.Add(game);
                        }
                        break;
                    case "Uninstall":
                        if (games.Contains(game))
                        {
                            games.Remove(game);
                        }
                        break;
                    case "Update":
                        if (games.Contains(game))
                        {
                            games.Remove(game);
                            games.Add(game);
                        }
                        break;
                    case "Expansion":

                        string[] gameTokens = game.Split('-').ToArray();
                        if (games.Contains(gameTokens[0]))
                        {
                            int index = games.IndexOf(gameTokens[0]);
                            games.Insert(index + 1, gameTokens[0] + ":" + gameTokens[1]);
                        }
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", games));
        }
    }
}
