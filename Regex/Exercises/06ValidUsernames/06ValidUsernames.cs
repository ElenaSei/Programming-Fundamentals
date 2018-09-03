using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _06ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" /\\()".ToCharArray());
            string pattern = @"\b([A-Za-z][\w\d]{2,24})\b";
            List<string> usernames = new List<string>();

            foreach (var item in input)
            {
                if (Regex.IsMatch(item, pattern))
                {
                    Match match = Regex.Match(item, pattern);
                    usernames.Add(match.Value);
                }
            }

            int sum = 0;
            int maxSum = 0;
            string bestUser1 = "";
            string bestUser2 = "";
            for (int i = 0; i < usernames.Count - 1; i++)
            {
                sum = usernames[i].Length + usernames[i + 1].Length;
                if (sum > maxSum)
                {
                    maxSum = sum;
                    bestUser1 = usernames[i];
                    bestUser2 = usernames[i + 1];
                }
            }

            Console.WriteLine(bestUser1);
            Console.WriteLine(bestUser2);
        }
    }
}
