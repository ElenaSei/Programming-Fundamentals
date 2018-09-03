using System;

namespace _04DrawAFilledSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            PrintTopBottom(num);
            PrintMiddleRow(num);
            PrintTopBottom(num);
        }

        static void PrintMiddleRow(int number)
        {
            for (int i = 1; i <= number - 2; i++)
            {
            Console.Write('-');
            for (int k = 1; k < number; k++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine('-');
            }
        }

        static void PrintTopBottom(int number)
        {
            Console.WriteLine(new string('-', number * 2));
        }
    }
}
