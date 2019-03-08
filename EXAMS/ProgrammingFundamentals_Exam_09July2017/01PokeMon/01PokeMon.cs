using System;

namespace _01PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            double power = double.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustion = int.Parse(Console.ReadLine());

            int currentPower = (int)power;
            int counter = 0;
            while (currentPower >= distance)
            {
                currentPower -= distance;

                if (exhaustion != 0 && currentPower == power / 2)
                {
                    currentPower /= exhaustion;
                }

                counter++;
            }

            Console.WriteLine(currentPower);
            Console.WriteLine(counter);

        }
    }
}
