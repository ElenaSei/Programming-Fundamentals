using System;
using System.Text.RegularExpressions;

namespace _04MatchDates
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(?<day>\d{2})(?<separator>.|-|\/)(?<month>[A-Z][a-z]{2})(\k<separator>)(?<year>\d{4})";
            var dates = Regex.Matches(input, pattern);
            foreach (Match date in dates)
            {
                var day = date.Groups["day"].Value;
                var month = date.Groups["month"].Value;
                var year = date.Groups["year"].Value;
                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
