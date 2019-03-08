using System;
using System.Text.RegularExpressions;

namespace _04WinningTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tickets = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string pattern = @"[@]{6,10}|[#]{6,10}|[$]{6,10}|[\^]{6,10}";

            foreach (var ticket in tickets)
            {
                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }
                string leftSide = ticket.Substring(0, 10);
                string rightSide = ticket.Substring(10, 10);
                var matchLeft = Regex.Match(leftSide, pattern);
                var matchRight = Regex.Match(rightSide, pattern);

                if (Regex.IsMatch(leftSide, pattern)
                    && Regex.IsMatch(rightSide, pattern)
                    && matchLeft.Value[0] == matchRight.Value[0])
                {
                    if (matchLeft.Length == 10 && matchRight.Length == 10)
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - 10{matchLeft.Value[0]} Jackpot!");
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - {Math.Min(matchLeft.Length, matchRight.Length)}{matchLeft.Value[0]}");
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
