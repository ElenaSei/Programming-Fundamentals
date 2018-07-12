using System;
using System.Collections.Generic;
using System.Linq;

namespace _07CountNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                                       .Split(' ')
                                       .Select(int.Parse)
                                       .ToArray();
            int max = numbers.Max();
            int[] count = new int[max + 1];
            for (int i = 0; i < numbers.Length; i++)
            {
                count[numbers[i]]++;
            }
            for (int i = 0; i < count.Length; i++)
            {
                if (count[i] > 0)
                {
                    Console.WriteLine($"{i} -> {count[i]}");
                }
            }
            /*List<int> numbers = Console.ReadLine()
                                       .Split(' ')
                                       .Select(int.Parse)
                                       .ToList();
            numbers.Sort();
            int counter = 1;
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    counter++;
                }
                else
                {
                    Console.WriteLine(numbers[i] + " -> " + counter);
                    counter = 1;
                }
            }
            Console.WriteLine(numbers[numbers.Count-1] + " -> " + counter);
            */
        }
    }
}
