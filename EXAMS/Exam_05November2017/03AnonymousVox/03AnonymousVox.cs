using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03AnonymousVox
{
    class Program
    {
        static void Main(string[] args)
        {
            string encodedText = Console.ReadLine();
            List<string> values = Console.ReadLine().Split(new char[] { '{', '}' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            string pattern = @"(?<start>[A-Za-z]+)(?<placeholder>.+)(\k<start>)";

            var matches = Regex.Matches(encodedText, pattern);
            int count = 0;
            foreach (Match item in matches)
            {
                string decodedText = item.Groups["start"] + values[count++] + item.Groups["start"];
                encodedText = encodedText.Replace(item.Value, decodedText);
            }
            Console.WriteLine(encodedText);
        }
    }
}
