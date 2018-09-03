using System;
using System.Text.RegularExpressions;

namespace _05KeyReplacer
{
    class Program
    {
        static void Main(string[] args)
        {
            string keys = Console.ReadLine();
            string text = Console.ReadLine();

            string keyPattern = @"(?<startKey>[A-Za-z]+)([\\|<])(.*)([\\|<])(?<endKey>[A-Za-z]+)";

            Match match = Regex.Match(keys, keyPattern);
            string startKey = match.Groups["startKey"].Value;
            string endKey = match.Groups["endKey"].Value;

            string textPattern = startKey + @"(.*?)" + endKey;

            MatchCollection result = Regex.Matches(text, textPattern);

            string output = "";
            foreach (Match item in result)
            {
                output += item.Groups[1].Value;

            }
            if (string.IsNullOrEmpty(output))
            {
                Console.Write("Empty result");
            }
            else
            {
                Console.WriteLine(output); 
            }
        }
    }
}
