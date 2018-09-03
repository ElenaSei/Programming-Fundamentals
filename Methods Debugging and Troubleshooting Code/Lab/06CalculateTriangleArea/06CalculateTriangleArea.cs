using System;

namespace _06CalculateTriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine()); 
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine(GetTriangleArea(width, height));
        }

        static double GetTriangleArea(double width, double height)
        {
            return 0.5 * width * height;
        }
    }
}
