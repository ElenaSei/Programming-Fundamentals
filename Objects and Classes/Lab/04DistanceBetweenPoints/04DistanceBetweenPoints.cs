using System;
using System.Linq;

namespace _04DistanceBetweenPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] point1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] point2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        }
    }
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}
