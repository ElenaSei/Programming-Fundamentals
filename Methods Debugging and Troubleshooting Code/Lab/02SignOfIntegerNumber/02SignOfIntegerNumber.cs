using System;

namespace _02SignOfIntegerNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            PrintSign(num);
        }

        static void PrintSign(int number)
        {
            if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {number} is zero.");
            }
        }


		/*int number = int.Parse(Console.ReadLine());
            string result = GetNumberSign(number);
            Console.WriteLine($"The number {number} is {result}.");
        }

        private static string GetNumberSign(int number)
        {
            string result = "";
            if (number > 0)
            {
                result = "positive";
            }
            else if (number < 0)
            {
                result = "negative";
            }
            else
            {
                result = "zero";
            }
            return result;
        }
        */
    }
}
