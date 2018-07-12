using System;
using System.Collections.Generic;
using System.Linq;

namespace _06SumReversedNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            int sum = 0;
            foreach (var num in nums)
            {
                List<char> number = num.ToString().Reverse().ToList();
                sum += int.Parse(string.Join("", number));
            }
            Console.WriteLine(sum);
        }
    }
}
