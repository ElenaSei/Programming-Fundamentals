using System;

namespace _09MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));
            int multipleNum = GetMultipleOfEvensAndOdds(number);
            Console.WriteLine(multipleNum);
        }

        static int GetMultipleOfEvensAndOdds(int number)
        {
            int sumEven = 0;
            int sumOdd = 0;
            while (number > 0)
            {
                int lastDigit = number % 10;
                if (lastDigit % 2 == 0)
                {
                    sumEven += lastDigit;
                }
                else
                {
                    sumOdd += lastDigit;
                }
                number /= 10;
            }
            return sumOdd * sumEven;
        }
    }
}
