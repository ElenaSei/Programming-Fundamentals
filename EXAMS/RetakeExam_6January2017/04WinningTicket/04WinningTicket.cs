using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04WinningTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] collection = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string pattern = @"[@]{6,10}|[#]{6,10}|[$]{6,10}|[\^]{6,10}";

            foreach (var ticket in collection)
            {
                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }

                string firstPart = ticket.Substring(0, 10);
                string secondPart = ticket.Substring(10, 10);
                var match1 = Regex.Match(firstPart, pattern);
                var match2 = Regex.Match(secondPart, pattern);

                if (Regex.IsMatch(firstPart, pattern)
                    && Regex.IsMatch(secondPart, pattern)
                    && match1.Groups[0].Value[0] == match2.Groups[0].Value[0])
                {
                    if (Math.Min(match1.Length, match2.Length) == 10)
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - 10{ticket[0]} Jackpot!");
                    }
                    else
                    {
                        int index = match1.Index;
                        int length = Math.Min(match1.Length, match2.Length);
                        Console.WriteLine($"ticket \"{ticket}\" - {length}{ticket[index]}");
                    }
                }
                else
                {
                    Console.WriteLine($"ticket \"{ticket}\" - no match");
                }
            }
        }
    }
}
