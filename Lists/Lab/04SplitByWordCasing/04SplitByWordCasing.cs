using System;
using System.Collections.Generic;

namespace _04SplitByWordCasing
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                                       .Split(",;:.!()\"'\\/[] ".ToCharArray()
                                              , StringSplitOptions.RemoveEmptyEntries);
            List<string> lowerCase = new List<string>();
            List<string> upperCase = new List<string>();
            List<string> mixedCase = new List<string>();

            foreach (var word in words)
            {
                if (IsUppeWord(word))
                {
                    upperCase.Add(word);
                }
                else if (IsLowerWord(word))
                {
                    lowerCase.Add(word);
                }
                else
                {
                    mixedCase.Add(word);
                }
            }
            Console.WriteLine($"Lower-case: {string.Join(", ", lowerCase)}");
            Console.WriteLine($"Mixed-case: {string.Join(", ", mixedCase)}");
            Console.WriteLine($"Upper-case: {string.Join(", ", upperCase)}");
        }
        static bool IsUppeWord(string word)
        {
            foreach (char symbol in word)
            {
                if (symbol < 'A' || symbol > 'Z')
                {
                    return false;
                }
            }
            return true;
        }
        static bool IsLowerWord(string word)
        {
            foreach (char symbol in word)
            {
                if (symbol < 'a' || symbol > 'z')
                {
                    return false;
                }
            }
            return true;
        }
    }
}
