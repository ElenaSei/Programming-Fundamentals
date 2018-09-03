using System;

namespace _09LongerLine
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            PrintLongestLine(x1, y1, x2, y2, x3, y3, x4, y4);
        }
        static void PrintLongestLine(double x1, double y1, double x2, double y2,
                                     double x3, double y3, double x4, double y4)
        {
            double point1 = CalculatePythagorean(x1, y1);
            double point2 = CalculatePythagorean(x2, y2);
            double point3 = CalculatePythagorean(x3, y3);
            double point4 = CalculatePythagorean(x4, y4);

            if (point1 + point2 >= point3 + point4)
            {
                if (point1 <= point2)
                {
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                }
                else
                {
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
                }
            }
            else
            {
                if (point3 <= point4)
                {
                    Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
                }
                else
                {
                    Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
                }
            }
        }
        private static double CalculatePythagorean(double x, double y)
        {
            return Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
        }
    }
}
