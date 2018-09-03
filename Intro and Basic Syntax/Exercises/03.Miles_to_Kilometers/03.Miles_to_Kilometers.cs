using System;

namespace _03.Miles_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            double mile = double.Parse(Console.ReadLine());
            double km = mile * 1.60934;
            Console.WriteLine($"{km:f2}");
        }
    }
}
