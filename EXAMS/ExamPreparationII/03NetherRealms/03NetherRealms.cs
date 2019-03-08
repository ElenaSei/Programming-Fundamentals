using System;
using System.Text.RegularExpressions;

namespace _03NetherRealms
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] demons = Console.ReadLine().Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            Array.Sort(demons);

            string patternHealth = @"[^\d+\-*\/.]";
            string patternDamage = @"([+-]?\d+\.?\d*)";

            foreach (var demon in demons)
            {
                var matchesHealth = Regex.Matches(demon, patternHealth);
                int health = 0;

                foreach (Match match in matchesHealth)
                {
                    health += char.Parse(match.Groups[0].Value);
                }

                var matchesDamage = Regex.Matches(demon, patternDamage);
                double damage = 0;

                foreach (Match match in matchesDamage)
                {
                    damage += double.Parse(match.Groups[0].Value);
                }

                foreach (var symbol in demon)
                {
                    if (symbol == '*')
                    {
                        damage *= 2;
                    }
                    else if (symbol == '/')
                    {
                        damage /= 2;
                    }
                }

                Console.WriteLine($"{demon} - {health} health, {damage:f2} damage");
            }
        }
    }
}
