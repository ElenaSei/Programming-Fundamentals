using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _08UseYourChainsBuddy
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"<p>(.*?)<\/p>";
            var matches = Regex.Matches(input, pattern);
            Dictionary<char, char> alphabet = new Dictionary<char, char>();
            for (int i = 'a'; i <= 'm'; i++)
            {
                int symbol = int.Parse(i.ToString()) + 13;
                alphabet.Add((char)i, (char)symbol);
            }

            StringBuilder result = new StringBuilder();
            foreach (Match match in matches)
            {
                string text = match.Groups[1].Value;
                text = Regex.Replace(text, @"[^a-z\d]+", " ");
                char[] textChar = text.ToCharArray();

                for (int i = 0; i < textChar.Length; i++)
                {
                    char symbol = textChar[i];
                    if (alphabet.ContainsKey(symbol))
                    {
                        textChar[i] = alphabet[symbol];
                    }
                    else if (alphabet.ContainsValue(symbol))
                    {
                        textChar[i] = alphabet.First(s => s.Value == symbol).Key;
                    }
                }
                result.Append(string.Join("", textChar));
            }

            Console.WriteLine(result);
        }
    }
}
