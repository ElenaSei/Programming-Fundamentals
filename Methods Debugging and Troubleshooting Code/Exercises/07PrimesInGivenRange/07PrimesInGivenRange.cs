using System;
using System.Collections.Generic;

namespace _07PrimesInGivenRange
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            List<int> primeNumbers = new List<int>();

            for (int i = number1; i <= number2; i++)
            {
                if (IsPrime(i))
                {
                    primeNumbers.Add(i);
                }
            }

            Console.WriteLine(string.Join(", ", primeNumbers));
        }

        static bool IsPrime(int number)
        {
            if (number > 1)
            {
                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                    {
                        return false;
                    }
                }
            }
            else
            {
                return false;
            }
            return true;
        }

    }
}
