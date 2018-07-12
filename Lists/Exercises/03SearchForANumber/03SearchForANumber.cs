using System;
using System.Collections.Generic;
using System.Linq;

namespace _03SearchForANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                                       .Split(' ')
                                       .Select(int.Parse)
                                       .ToList();
            int[] commands = Console.ReadLine()
                                    .Split(' ')
                                    .Select(int.Parse)
                                    .ToArray();

            /*
             * numbers.Take(commands[0]);
            numbers.RemoveRange(0, commands[1]);
            if (numbers.Exists(num => num == commands[2]))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
            */
            if(numbers.Take(commands[0]).Skip(commands[1]).Contains(commands[2]))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
