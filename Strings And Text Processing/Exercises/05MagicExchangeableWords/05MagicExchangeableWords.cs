using System;
using System.Collections.Generic;
using System.Linq;

namespace _05MagicExchangeableWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string word1 = input[0];
            string word2 = input[1];

            Dictionary<char, char> magicChars = new Dictionary<char, char>();
            bool isExchangeable = true;

            for (int i = 0; i < Math.Min(word1.Length, word2.Length); i++)
            {
                if (!magicChars.ContainsKey(word1[i]))
                {
                    if (!magicChars.ContainsValue(word2[i]))
                    {
                        magicChars.Add(word1[i], word2[i]);
                    }
                    else
                    {
                        isExchangeable = false;
                        break;
                    }
                }
                else
                {
                    if (magicChars[word1[i]] != word2[i])
                    {
                        isExchangeable = false;
                        break;
                    }
                }
            }

            for (int i = Math.Min(word1.Length, word2.Length); i < Math.Max(word1.Length, word2.Length); i++)
            {

                if (word1.Length > word2.Length)
                {
                    if (!magicChars.ContainsKey(word1[i]))
                    {
                        isExchangeable = false;
                        break;
                    }
                }
                else if (word1.Length < word2.Length)
                {
                    if (!magicChars.ContainsValue(word2[i]))
                    {
                        isExchangeable = false;
                        break;
                    }
                }
            }

            Console.WriteLine(isExchangeable.ToString().ToLower());
        }
    }
}
