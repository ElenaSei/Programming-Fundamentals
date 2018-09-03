using System;

namespace _08CenterPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            PrintClosestCoordinates(x1, y1, x2, y2);
        }
        static void PrintClosestCoordinates(double x1, double y1, double x2, double y2)
        {
            double point1 = CalculatePythagorean(x1, y1);
            double point2 = CalculatePythagorean(x2, y2);

            if (point1 <= point2)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }

        private static double CalculatePythagorean(double x, double y)
        {
            return Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
        }
    }
}
