using System;
using System.Collections.Generic;
using System.Linq;

namespace _01CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                                      .Split(' ')
                                      .Select(double.Parse)
                                      .ToArray();
            var count = new SortedDictionary<double, int>();
            foreach (var number in numbers)
            {
                if (count.ContainsKey(number))
                {
                    count[number]++;
                }
                else
                {
                    count.Add(number, 1);
                }
            }
            foreach (var num in count)
            {
                Console.WriteLine("{0} -> {1}", num.Key, num.Value);
            }
        }
    }
}
