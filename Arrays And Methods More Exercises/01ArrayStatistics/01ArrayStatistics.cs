using System;
using System.Linq;

namespace _01ArrayStatistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                                   .Split(' ')
                                   .Select(int.Parse)
                                   .ToArray();
            
            int minNum = int.MaxValue;
            int maxNum = int.MinValue;
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < minNum)
                {
                    minNum = numbers[i];
                }
                if (numbers[i] > maxNum)
                {
                    maxNum = numbers[i];
                }
                sum += numbers[i];
            }
            double average = (double)sum / numbers.Length;

            Console.WriteLine($"Min = {minNum}");
            Console.WriteLine($"Max = {maxNum}");
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Average = {average}");
        }
    }
}
