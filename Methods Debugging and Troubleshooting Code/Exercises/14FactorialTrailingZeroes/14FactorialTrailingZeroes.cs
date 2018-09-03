using System;
using System.Numerics;

namespace _14FactorialTrailingZeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger factorial = BigInteger.Parse(Console.ReadLine());

            PrintNumOfZeros(factorial);
        }

        static void PrintNumOfZeros(BigInteger factorial)
        {
            
            BigInteger remainder = 0;
            BigInteger counter = 0;
            BigInteger sum = FindFactorial(factorial);

            while (sum > 0)
            {
                remainder = sum % 10;
                sum = sum / 10;
                if (remainder == 0)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }

        static BigInteger FindFactorial(BigInteger factorial)
        {
            BigInteger sum = 1;
            for (int i = 1; i <= factorial; i++)
            {
                sum *= i;
            }
            return sum;
        }
    }
}
