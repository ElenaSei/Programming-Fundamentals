using System;
using System.Collections.Generic;
using System.Linq;

namespace _07BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                                       .Split(' ')
                                       .Select(int.Parse)
                                       .ToList();
            List<int> bombNumbers = Console.ReadLine()
                                       .Split(' ')
                                       .Select(int.Parse)
                                       .ToList();
            int bomb = bombNumbers[0];
            int bombPower = bombNumbers[1];
            int position = numbers.IndexOf(bomb);

            while (numbers.Contains(bomb))
            {
                int leftPosition = position - bombPower;
                int rightPosition = position + bombPower;

                if (leftPosition < 0)
                {
                    leftPosition = 0;
                }
                if (rightPosition > numbers.Count - 1)
                {
                    rightPosition = numbers.Count - 1;
                }

                int count = rightPosition - leftPosition + 1;
                numbers.RemoveRange(leftPosition, count);
                position = numbers.IndexOf(bomb);
            }

            Console.WriteLine(numbers.Sum());
        }
    }
}
