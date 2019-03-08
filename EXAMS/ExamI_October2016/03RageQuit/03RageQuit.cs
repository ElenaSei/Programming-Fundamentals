using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _03RageQuit
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToUpper();
            string pattern = @"([^\d]+)([\d]+)";
            List<char> unicSymbols = new List<char>();

            var matches = Regex.Matches(input, pattern);
            StringBuilder result = new StringBuilder();

            foreach (Match match in matches)
            {
                
                int number = int.Parse(match.Groups[2].Value);
                string text = match.Groups[1].Value;

                if (number > 0)
                {
                    unicSymbols.AddRange(text.ToCharArray());
                }

                for (int i = 0; i < number; i++)
                {
                    result.Append(text);
                }

            }

            unicSymbols = unicSymbols.Distinct().ToList();

            Console.WriteLine($"Unique symbols used: {unicSymbols.Count}");
            Console.WriteLine(result);
        }
    }
}
