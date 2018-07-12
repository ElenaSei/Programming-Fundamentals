using System;
using System.Linq;

namespace _03IntersectionОfCircles
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = ReadCircle(Console.ReadLine());
            Circle circle2 = ReadCircle(Console.ReadLine());

            double distance = Math.Sqrt(Math.Pow(circle2.Point.X - circle1.Point.X, 2) +
                                        Math.Pow(circle2.Point.Y - circle1.Point.Y, 2));

            double sumRadius = circle1.Radius + circle2.Radius;

            bool intersect = distance <= sumRadius;

            if (intersect)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        private static Circle ReadCircle(string input)
        {
            double[] tokens = input.Split().Select(double.Parse).ToArray();

            double x = tokens[0];
            double y = tokens[1];
            double radius = tokens[2];

            Point point = new Point(x, y);
            Circle circle = new Circle(point, radius);

            return circle;
        }
    }
    class Point
    {
        public double X { get; set; }
        public double Y {get;set;}

        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

    }
    class Circle
    {
        public Point Point {get; set;}
        public double Radius { get; set; }

        public Circle() { }

        public Circle(Point point, double radius)
        {
            this.Point = point;
            this.Radius = radius;
        }

    }
}
