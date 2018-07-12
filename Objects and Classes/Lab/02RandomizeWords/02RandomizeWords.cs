using System;
using System.Collections.Generic;
using System.Linq;

namespace _02RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                                    .Split(' ')
                                    .ToArray();
            Random random = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                int position = random.Next(0, words.Length - 1);
                string temp = words[i];
                words[i] = words[position];
                words[position] = temp;
            }
            Console.WriteLine(string.Join(Environment.NewLine, words));
        }
    }
}
