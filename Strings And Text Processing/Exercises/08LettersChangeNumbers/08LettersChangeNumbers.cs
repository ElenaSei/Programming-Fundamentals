using System;
using System.Linq;

namespace _08LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            double sum = 0;
            double tempSum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                char firstLetter = input[i].ElementAt(0);
                char lastLetter = input[i].ElementAt(input[i].Length - 1);
                string num = new string(input[i].Skip(1).Take(input[i].Length - 2).ToArray());
                tempSum = int.Parse(num);
                if (char.IsUpper(firstLetter))
                {
                    tempSum /= (firstLetter - 64);
                }
                else
                {
                    tempSum *= (firstLetter - 96);
                }
                if (char.IsUpper(lastLetter))
                {
                    tempSum -= (lastLetter - 64);
                }
                else
                {
                    tempSum += (lastLetter - 96);
                }
                sum += tempSum;
            }
            Console.WriteLine($"{sum:f2}");
        }
    }
}
