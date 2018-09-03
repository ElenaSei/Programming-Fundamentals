using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([A-Z]{2})([\d]+\.[\d]+)([A-Za-z]+)(?=\|)";
            Dictionary<string, KeyValuePair<double, string>> weather = new Dictionary<string, KeyValuePair<double, string>>();
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                var matches = Regex.Matches(input, pattern);

                foreach (Match match in matches)
                {
                    string city = match.Groups[1].Value;
                    double temperature = double.Parse(match.Groups[2].Value);
                    string weatherType = match.Groups[3].Value;

                    if (!weather.ContainsKey(city))
                    {
                        weather.Add(city, new KeyValuePair<double, string>(temperature, weatherType));
                    }
                    weather[city] = new KeyValuePair<double, string>(temperature, weatherType);
                }
            }

            foreach (var kvp in weather.OrderBy(c => c.Value.Key))
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value.Key:f2} => {kvp.Value.Value}");
            }
        }
    }
}
