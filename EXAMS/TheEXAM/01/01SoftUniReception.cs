using System;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            int employee1 = int.Parse(Console.ReadLine());
            int employee2 = int.Parse(Console.ReadLine());
            int employee3 = int.Parse(Console.ReadLine());
            int customersCount = int.Parse(Console.ReadLine());

            int efficiency = employee1 + employee2 + employee3;

            if (customersCount == 0)
            {
                Console.WriteLine("Time needed: 0h.");
                return;
            }
            int counter = 1;
            while (customersCount > efficiency)
            {
                customersCount -= efficiency;
                counter++;

                if (counter % 4 == 0)
                {
                    counter++;
                }
            }

            Console.WriteLine($"Time needed: {counter}h.");
        }
    }
}
