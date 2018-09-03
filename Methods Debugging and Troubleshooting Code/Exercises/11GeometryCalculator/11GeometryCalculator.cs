using System;

namespace _11GeometryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            PrintArea(figure);
        }

        static void PrintArea(string figure)
        {
            double area = 0;
            if (figure == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                area = 0.5 * side * height;
            }
            else if (figure == "square")
            {
                double side = double.Parse(Console.ReadLine());
                area = Math.Pow(side, 2);
            }
            else if (figure == "rectangle")
            {
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                area = width * height;
            }
            else if (figure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                area = Math.PI * Math.Pow(radius, 2);
            }
            Console.WriteLine($"{area:f2}");
        }
    }
}
