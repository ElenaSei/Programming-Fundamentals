using System;
using System.Collections.Generic;
using System.Linq;

namespace _06SquareNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                                       .Split(' ')
                                       .Select(int.Parse)
                                       .ToArray();
            List<int> squareNum = numbers.Where(num => Math.Sqrt(num) == (int)Math.Sqrt(num)).ToList();
            squareNum = squareNum.OrderByDescending(a => a).ToList();
            //или squareNum.Sort();
            //    squareNum.Reverse();
            //или squareNum.Sort((a, b) => b.CompareTo(a));
            Console.WriteLine(string.Join(" ", squareNum));
        }
    }
}
