using System;

namespace _07MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            Console.WriteLine(RaiseToPower(num, power));
        }

        static double RaiseToPower(double num, int power)
        {
            double result = Math.Pow(num, power);
            return result;
        }
    }
}
