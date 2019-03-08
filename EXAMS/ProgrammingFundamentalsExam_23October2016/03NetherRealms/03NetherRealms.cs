using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03NetherRealms
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] demons = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string healthPattern = @"[^0-9+\-*\/.]";
            string damagePattern = @"[[0-9\-+]+\.?[0-9]*|\*|\/";
            Dictionary<string, List<double>> demonsStats = new Dictionary<string, List<double>>();
            foreach (var demon in demons)
            {
                var matchHealth = Regex.Matches(demon, healthPattern);
                var matchDamage = Regex.Matches(demon, damagePattern);
                int demonHealth = 0;
                double demonDamage = 0;
                List<string> damage = new List<string>();
                foreach (Match symbol in matchHealth)
                {
                    demonHealth += char.Parse(symbol.Value);
                }
                foreach (Match symbol in matchDamage)
                {
                    damage.Add(symbol.Value);
                }
                for (int i = 0; i < damage.Count; i++)
                {
                    if (damage[i].StartsWith("-"))
                    {
                        damage[i] = damage[i].Remove(0, 1);
                        if (double.TryParse(damage[i], out double result))
                        {
                            demonDamage += result;
                        }
                    }
                    else if (damage[i].StartsWith("+"))
                    {
                        damage[i] = damage[i].Remove(0, 1);
                        if (double.TryParse(damage[i], out double result))
                        {
                            demonDamage += result;
                        }
                    }
                    else if (double.TryParse(damage[i], out double result))
                    {
                        demonDamage += result;
                    }
                }
                for (int i = 0; i < damage.Count; i++)
                {
                    if (damage[i] == "*")
                    {
                        demonDamage *= 2;
                    }
                    else if (damage[i] == "/")
                    {
                        demonDamage /= 2;
                    }
                }
                List<double> temp = new List<double>();
                temp.Add(demonHealth);
                temp.Add(demonDamage);
                demonsStats.Add(demon, temp);
            }
            foreach (var demon in demonsStats.OrderBy(d => d.Key))
            {
                Console.WriteLine($"{demon.Key} - {demon.Value[0]} health, {demon.Value[1]:f2} damage");
            }
        }
    }
}
