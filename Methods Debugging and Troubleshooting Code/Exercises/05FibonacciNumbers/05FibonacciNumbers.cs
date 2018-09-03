using System;

namespace _05FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int fibonacciNumber = GetFibonacciNumber(num);
            Console.WriteLine(fibonacciNumber);
        }

        private static int GetFibonacciNumber(int num)
        {
            int num1 = 0;
            int num2 = 1;
            int fibonacciNumber = 0;

            if (num == 0)
            {
                fibonacciNumber = 1;
            }
            for (int i = 1; i <= num; i++)
            {
                fibonacciNumber = num1 + num2;
                num1 = num2;
                num2 = fibonacciNumber;
            }
            return fibonacciNumber;
        }
    }
}
