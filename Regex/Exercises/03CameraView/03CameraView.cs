using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03CameraView
{
    class Program
    {
        protected static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                                .Split(' ')
                                .Select(int.Parse)
                                .ToArray();
            int skip = nums[0];
            int take = nums[1];
            string input = Console.ReadLine();
            string pattern = @"(\|)(<[\w]{" + skip + @"})([\w]{0," + take + @"})";

            MatchCollection result = Regex.Matches(input, pattern);
            List<string> matches = new List<string>();
            foreach (Match item in result)
            {
                matches.Add(item.Groups[3].ToString());
            }
            Console.WriteLine(string.Join(", ", matches));

            /*
             * int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string text = Console.ReadLine();

            int skip = elements[0];
            int take = elements[1];
            string pattern = @"\|<([^|<]+)";

            var matches = Regex.Matches(text, pattern);

            List<string> result = new List<string>();

            foreach (Match match in matches)
            {
                string output = match.Groups[1].Value;
                output = string.Join("", output.Skip(skip).Take(take).ToArray());
                result.Add(output);
            }

            Console.WriteLine(string.Join(", ", result));
             */
        }
    }
}
