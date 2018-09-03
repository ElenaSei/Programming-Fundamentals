using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03MatchHexadecimalNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"\b(?:0x)?[0-9A-F]+\b";
            var numbers = Regex.Matches(input, pattern)
                                           .Cast<Match>()
                                           .Select(n => n.Value)
                                           .ToArray();
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
