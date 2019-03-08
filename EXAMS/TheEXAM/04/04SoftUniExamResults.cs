using System;
using System.Collections.Generic;
using System.Linq;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> users = new Dictionary<string, int>();
            Dictionary<string, int> submissions = new Dictionary<string, int>();

            string input;
            while ((input = Console.ReadLine()) != "exam finished")
            {
                string[] tokens = input.Split('-');

                if (tokens.Length == 3)
                {
                    string name = tokens[0];
                    string language = tokens[1];
                    int points = int.Parse(tokens[2]);

                    if (!users.ContainsKey(name))
                    {
                        users.Add(name, points);
                    }
                    else if(users[name] < points)
                    {
                        users[name] = points;
                    }
                    if (!submissions.ContainsKey(language))
                    {
                        submissions.Add(language, 0);
                    }
                    submissions[language]++;

                }
                else if (tokens.Length == 2)
                {
                    string name = tokens[0];

                    if (users.ContainsKey(name))
                    {
                        users.Remove(name);
                    }
                }
            }

            Console.WriteLine("Results:");

            foreach (var kvp in users.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine(kvp.Key + " | " + kvp.Value);
            }

            Console.WriteLine("Submissions:");

            foreach (var kvp in submissions.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine(kvp.Key + " - " + kvp.Value);
            }

        }
    }
}