using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03Regexmon
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string patternDidi = @"[^A-Za-z-]+";
            string patternBojo = @"[A-Za-z)]+-[A-Za-z)]+";

            while (true)
            {
                if (Regex.IsMatch(line, patternDidi))
                {
                    Console.WriteLine(Regex.Match(line, patternDidi));
                    var match = Regex.Match(line, patternDidi);
                    line = line.Substring(match.Index + match.Length);
                }
                else
                {
                    break;
                }
                if (Regex.IsMatch(line, patternBojo))
                {
                    Console.WriteLine(Regex.Match(line, patternBojo));
                    var match = Regex.Match(line, patternBojo);
                    line = line.Substring(match.Index + match.Length);
                }
                else
                {
                    break;
                }
            }
        }
    }
}
