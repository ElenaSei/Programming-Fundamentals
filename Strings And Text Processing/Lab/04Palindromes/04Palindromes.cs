using System;
using System.Collections.Generic;
using System.Linq;

namespace _04Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                                    .Split(new char[] { ' ', ',', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries)
                                    .ToArray();
            List<string> ouput = new List<string>();

            foreach (var word in input)
            {
                string reversedWord = new string(word.Reverse().ToArray());
                if (word == reversedWord)
                {
                    ouput.Add(word);
                }

            }
            Console.WriteLine(string.Join(", ", ouput.OrderBy(x => x)));
        }
    }
}