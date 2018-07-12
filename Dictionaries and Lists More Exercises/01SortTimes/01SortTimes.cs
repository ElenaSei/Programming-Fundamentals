using System;
using System.Collections.Generic;
using System.Linq;

namespace _01SortTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            var date = Console.ReadLine()
                              .Split(' ')
                              .OrderBy(t => t)
                              .ToList();
            Console.WriteLine(string.Join(", ", date));
            
        }
    }
}
