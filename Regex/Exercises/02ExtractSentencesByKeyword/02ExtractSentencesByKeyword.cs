using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02ExtractSentencesByKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string[] sentences = Console.ReadLine()
                                        .Split(new char[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries)
                                        .ToArray();
            string pattern = $@"\b{word}\b";

            foreach (var sentence in sentences)
            {
                if (Regex.IsMatch(sentence, pattern))
                {
                    Console.WriteLine(sentence.Trim());
                }
            }
        }
    }
}