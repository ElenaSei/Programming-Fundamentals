using System;
using System.Collections.Generic;
using System.Linq;

namespace _02ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                                       .Split(' ')
                                       .Select(int.Parse)
                                       .ToList();
            bool oddEven = false;
            while (!oddEven)
            {
                List<string> commands = Console.ReadLine()
                                               .Split(' ')
                                               .ToList();
                if (commands[0] == "Delete")
                {
                    numbers.RemoveAll(n => n == int.Parse(commands[1]));
                }
                else if (commands[0] == "Insert")
                {
                    numbers.Insert(int.Parse(commands[2]), int.Parse(commands[1]));
                }
                else if (commands[0] == "Odd" || commands[0] == "Even")
                {
                    PrintResult(numbers, commands);
                    oddEven = true;
                }
            }
        }

        static void PrintResult(List<int> numbers, List<string> commands)
        {
                if (commands[0] == "Even")
                {
                numbers.RemoveAll(num => num % 2 != 0);
                }
                else if (commands[0] == "Odd")
                {
                numbers.RemoveAll(num => num % 2 == 0);
                }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
