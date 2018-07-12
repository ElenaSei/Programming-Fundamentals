using System;
using System.Collections.Generic;
using System.Linq;

namespace _05SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine()
                                       .Split(' ')
                                          .Select(double.Parse)
                                       .ToList();
            numbers.Sort();
            Console.WriteLine(string.Join(" <= ", numbers));
        }
    }
}
