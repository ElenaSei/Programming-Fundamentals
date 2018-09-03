using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(\+359)( |-)2(\2)\d{3}(\2)\d{4}\b";

            MatchCollection phoneNums = Regex.Matches(input, pattern);
            var matchedPhones = phoneNums.Cast<Match>().Select(m => m.Value.Trim()).ToArray();
            Console.WriteLine(string.Join(", ", matchedPhones));
        }
    }
}
