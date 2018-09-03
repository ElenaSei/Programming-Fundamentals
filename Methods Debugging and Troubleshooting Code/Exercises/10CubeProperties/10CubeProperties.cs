using System;

namespace _10CubeProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();

            double result = GetResult(side, parameter);
            Console.Write($"{result:f2}");
        }

        private static double GetResult(double side, string parameter)
        {
            double result = 0;

            if (parameter == "face")
            {
                result = Math.Sqrt(2 * Math.Pow(side, 2));
            }
            else if (parameter == "space")
            {
                result = Math.Sqrt(3 * Math.Pow(side, 2));
            }
            else if (parameter == "volume")
            {
                result = Math.Pow(side, 3);
            }
            else if (parameter == "area")
            {
                result = 6 * Math.Pow(side, 2);
            }

            return result;
        }
    }
}
