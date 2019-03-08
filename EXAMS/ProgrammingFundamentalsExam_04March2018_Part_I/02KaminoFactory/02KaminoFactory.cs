using System;
using System.Collections.Generic;
using System.Linq;

namespace temp
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            List<string> allDna = new List<string>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Clone them!")
                {
                    break;
                }
                var dna = input.Split('!', StringSplitOptions.RemoveEmptyEntries);
                string dnaString = string.Join("", dna);
                allDna.Add(dnaString);
            }

            int[] indexes = new int[allDna.Count];

            for (int i = 0; i < indexes.Length; i++)
            {
                indexes[i] = GetIndex(allDna[i]);
            }

            int bestSample = 0;
            int bestIndex = indexes.Min();
            int bestSum = 0;

            for (int i = 0; i < indexes.Length; i++)
            {
                var sum = allDna[i].Select(x => int.Parse(x.ToString())).Sum();

                if (indexes[i] == bestIndex && sum > bestSum)
                {
                    bestSum = sum;
                    bestSample = i;
                }
            }

            char[] bestDna = allDna[bestSample].ToCharArray();
            Console.WriteLine($"Best DNA sample {bestSample + 1} with sum: {bestSum}.");
            Console.WriteLine(string.Join(" ", bestDna));
        }

        private static int GetIndex(string dna)
        {
            int counter = 0;
            int index = dna.Length - 1;
            int counterMax = 2; // ако е само една единицата да не влиза в последната проверка и да не ми сетва indexa!
            for (int i = dna.Length - 1; i >= 0; i--)
            {
                if (dna[i] == '1')
                {
                    counter++;
                }
                else
                {
                    counter = 0;
                }
                if (counter >= counterMax)
                {
                    counterMax = counter;
                    index = i;
                }
            }
            return index;
        }
    }
}