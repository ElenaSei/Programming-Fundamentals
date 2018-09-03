using System;
using System.Linq;

namespace _04GrabAndGo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                                   .Split(' ')
                                   .Select(int.Parse)
                                   .ToArray();
            int number = int.Parse(Console.ReadLine());
            long sum = 0;
            bool notExist = true;
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                if (numbers[i] == number)
                {
                    for (int g = 0; g < i; g++)
                    {
                        sum += numbers[g];
                    }
                    notExist = false;
                    break;
                }
            }
            if (notExist)
            {
                Console.WriteLine("No occurrences were found!");
            }
            else
            {
                Console.WriteLine(sum);
            }
        }
    }
}
