using System;
using System.Numerics;

namespace _13Factorial
{
    class Program
    {
        static void Main(string[] args)
        {

            int factorial = int.Parse(Console.ReadLine());

            PrintNumber(factorial);
        }

        static void PrintNumber(int factorial)
        {
            BigInteger sum = 1;
            for (int i = 1; i <= factorial; i++)
            {
                sum *= i;
            }
            Console.Write(sum);
        }
    }
}
