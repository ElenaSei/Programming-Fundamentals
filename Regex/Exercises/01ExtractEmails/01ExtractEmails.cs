using System;
using System.Text.RegularExpressions;

namespace _01ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(^|(?<=\s))([a-z0-9]+)([._-][a-z0-9]+)?@([a-z]+)([\.-][a-z]+)*\.[a-z]+($|(?=))";

            MatchCollection validEmails = Regex.Matches(input, pattern);
            foreach (var email in validEmails)
            {
                Console.WriteLine(email);
            }
        }
    }
}
