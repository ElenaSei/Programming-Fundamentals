using System;
using System.Collections.Generic;
using System.Linq;

namespace _05ShortWordsSorted
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine()
                                          .ToLower()
                                          .Split(new char[] {'.',',',':',';','(',
                ')','[',']','"','\'','\\','/','!','?',' '}, StringSplitOptions.RemoveEmptyEntries)
                                          .ToList();
            var smallWords = words.Where(x => x.Length < 5).OrderBy(x => x).Distinct();
            Console.WriteLine(string.Join(", ", smallWords));
        }
    }
}
