using System;
using System.Numerics;

namespace _02ConvertFromBaseNToBase10
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int @base = int.Parse(input[0]);
            string numAsString = input[1];
            BigInteger sum = 0;
            int pow = 0;

            for (int i = numAsString.Length - 1; i >= 0; i--)
            {
                char currentChar = numAsString[i];
                int currentNum = int.Parse(currentChar.ToString());

                BigInteger currentSum = currentNum * BigInteger.Pow(@base, pow);
                sum += currentSum;
                pow++;
            }

            Console.WriteLine(sum);
        }
    }
}
