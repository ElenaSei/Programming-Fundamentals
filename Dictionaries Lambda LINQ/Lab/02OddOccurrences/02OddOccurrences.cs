using System;
using System.Collections.Generic;
using System.Linq;

namespace _02OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                                    .ToLower()
                                    .Split(' ')
                                    .ToArray();
            var counts = new Dictionary<string, int>();
            foreach (var word in words)
            {
                if (counts.ContainsKey(word))
                {
                    counts[word]++;
                }
                else
                {
					counts.Add(word, 1); 
                }
            }
            var oddOccurrences = new List<string>();
            foreach (var word in counts)
            {
                if (word.Value % 2 != 0)
                {
                    oddOccurrences.Add(word.Key);
                }
            }
            Console.WriteLine(string.Join(", ", oddOccurrences));
        }
    }
}
