using System;
using System.Collections.Generic;
using System.Linq;

namespace _02AnonymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> text = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToList();

            string input;
            while ((input = Console.ReadLine()) != "3:1")
            {
                string[] tokens = input.Split();
                string command = tokens[0];

                switch (command)
                {
                    case "merge":
                        int startIndex = int.Parse(tokens[1]);
                        int endIndex = int.Parse(tokens[2]);

                        GetMerged(text, startIndex, endIndex);
                        break;
                    case "divide":
                        int index = int.Parse(tokens[1]);
                        int partition = int.Parse(tokens[2]);

                        GetDivided(text, index, partition);
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", text));
        }

        private static void GetDivided(List<string> text, int index, int partition)
        {
            string[] result = new string[partition];
            string word = text[index];
            int wordLength = word.Length;
            int part = wordLength / partition;
            int reminder = wordLength % partition;

            for (int i = 0; i < partition; i++)
            {
                result[i] = string.Join("", word.Skip(i * part).Take(part).ToArray());
            }
            result[partition - 1] += string.Join("", word.Skip(partition * part).Take(reminder).ToArray());

            text.RemoveAt(index);
            text.InsertRange(index, result);

        }

        private static void GetMerged(List<string> text, int startIndex, int endIndex)
        {
            if (startIndex < 0 || startIndex > text.Count - 1)
            {
                startIndex = 0;
            }
            if (endIndex > text.Count - 1 || endIndex < 0)
            {
                endIndex = text.Count - 1;
            }

            string result = "";
            for (int i = startIndex; i <= endIndex; i++)
            {
                result += text[i];
            }

            text.RemoveRange(startIndex, endIndex - startIndex + 1);
            text.Insert(startIndex, result);
        }
    }
}
