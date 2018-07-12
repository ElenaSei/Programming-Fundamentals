using System;
using System.Collections.Generic;
using System.Linq;

namespace _02OddFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                                       .Split(' ')
                                       .Select(int.Parse)
                                       .ToList();
            numbers.RemoveAll(x => x % 2 != 0);
            int averageNum = (int)(numbers.Average());
            numbers = numbers.Select(x => x = x > averageNum ? ++x : --x).ToList();
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
