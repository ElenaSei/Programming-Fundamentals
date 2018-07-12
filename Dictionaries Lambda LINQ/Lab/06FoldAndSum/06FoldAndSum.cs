using System;
using System.Collections.Generic;
using System.Linq;

namespace _06FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                                          .Split(' ')
                                          .Select(int.Parse)
                                          .ToList();
            var rowLeft = numbers.Take((numbers.Count / 2) / 2).Reverse().ToList();
            numbers.Reverse();
            var rowRight = numbers.Take((numbers.Count / 2) / 2).ToList();
            numbers.Reverse();
            var row1 = rowLeft.Concat(rowRight).ToList();
            var row2 = numbers.Skip((numbers.Count / 2) / 2).Take(numbers.Count / 2).ToList();
            var sum = row1.Select((x, index) => x + row2[index]).ToList();
            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
