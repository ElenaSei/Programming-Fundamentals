using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string forceUser = "";
            string forceSide = "";
            string pattern1 = @"(?<forceSide>[^|\->]+)(\|)(?<forceUser>[^|\->]+)";
            string pattern2 = @"(?<forceUser>[^|\->]+)(\->)(?<forceSide>[^|\->]+)";
            Dictionary<string, List<string>> force = new Dictionary<string, List<string>>();
            while (input != "Lumpawaroo")
            {
                var regex1 = new Regex(pattern1);
                var regex2 = new Regex(pattern2);
                if (regex1.IsMatch(input))
                {
                    Match match = regex1.Match(input);
                    forceSide = match.Groups["forceSide"].Value.Trim();
                    forceUser = match.Groups["forceUser"].Value.Trim();
                    if (!force.ContainsKey(forceSide))
                    {
                        force.Add(forceSide, new List<string>());

                    }
                    if (!force.Any(x => x.Value.Contains(forceUser)))
                    {
                        force[forceSide].Add(forceUser);
                    }
                }
                else if (regex2.IsMatch(input))
                {
                    Match match = regex2.Match(input);
                    forceSide = match.Groups["forceSide"].Value.Trim();
                    forceUser = match.Groups["forceUser"].Value.Trim();
                    if (!force.ContainsKey(forceSide))
                    {
                        force.Add(forceSide, new List<string>());

                    }
                        bool containsUser = force.Any(x => x.Value.Contains(forceUser));
                        if (containsUser)
                        {
                            foreach (var pair in force.Where(x => x.Value.Contains(forceUser)))
                            {
                                foreach (var item in pair.Value)
                                {
                                    force[pair.Key].Remove(forceUser);
                                    break;
                                }
                            }
                            foreach (var pair in force.Where(x => !(x.Value.Contains(forceUser))))
                            {
                                foreach (var item in pair.Value)
                                {
                                    force[pair.Key].Remove(forceUser);
                                    break;
                                }
                            }
                            force[forceSide].Add(forceUser);
                            Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                        }
                        else
                        {
                            force[forceSide].Add(forceUser);
                            Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                        }

                }
                input = Console.ReadLine();
            }
            foreach (var side in force.OrderByDescending(u => u.Value.Count()).ThenBy(f => f.Key))
            {
                if (side.Value.Count() > 0)
                {
                    Console.WriteLine($"Side: {side.Key}, Members: {side.Value.Count()}");
                    foreach (var user in side.Value.OrderBy(u => u))
                    {

                        Console.WriteLine($"! {user}");
                    }
                }
            }
        }
    }
}
