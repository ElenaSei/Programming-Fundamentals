using System;
using System.Linq;

namespace _09JumpAround
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                                   .Split(' ')
                                   .Select(int.Parse)
                                   .ToArray();

            int jump = numbers[0];
            int sum = jump;
            int index = 0;
            while (true)
            {
                if (index + jump <= numbers.Length - 1)
                {
                    index += jump;
                    jump = numbers[index];
                    sum += jump;
                }
                else if (index - jump >= 0)
                {
                    index -= jump;
                    jump = numbers[index];
                    sum += jump;
                }
                else
                {
                    break;
                }

            }
            Console.WriteLine(sum);
        }
    }
}