using System;
using System.Linq;
using System.Numerics;
using System.Text;

namespace _01ConvertFromBase10ToBaseN
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int @base = int.Parse(input[0]);
            BigInteger number = BigInteger.Parse(input[1]);

            StringBuilder converted = new StringBuilder();

            while (number > 0)
            {
                BigInteger reminder = number % @base;
                converted.Append(reminder);
                number /= @base;
            }
            // string reversed = string.Join("", converted.ToString().Reverse());

            for (int i = converted.Length - 1; i >= 0; i--)
            {
                Console.Write(converted[i]);
            }
        }
    }
}
