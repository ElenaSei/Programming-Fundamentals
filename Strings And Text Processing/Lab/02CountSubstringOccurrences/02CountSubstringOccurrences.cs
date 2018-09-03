using System;
using System.Linq;

namespace _02CountSubstringOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            string word = Console.ReadLine().ToLower();
            int counter = 0;

            for (int i = 0; i <= text.Length - word.Length; i++)
            {
                char[] substring = text.Skip(i).Take(word.Length).ToArray();
                string toCheck = new string(substring);

                // има и такъв варинт: string sub = text.Substring(i, word.Length);

                if (toCheck == word)
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);

            /*
             * int index = text.IndexOf(pattern)
             * while(index != - 1)
             * {
             *      counter++;
             *      index = text.IndexOf(pattern, index + 1);
             *
             * }
             */
        }
    }
}
