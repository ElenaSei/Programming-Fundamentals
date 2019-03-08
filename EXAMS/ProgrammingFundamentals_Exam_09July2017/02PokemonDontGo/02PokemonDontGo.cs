using System;
using System.Collections.Generic;
using System.Linq;

namespace _02PokemonDontGo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> distances = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int sum = 0;

            while (distances.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());
                int temp = 0;

                if (index < 0)
                {
                    temp = distances[0];
                    sum += distances[0];
                    distances[0] = distances.Last();
                }
                else if (index >= distances.Count)
                {
                    temp = distances[distances.Count - 1];
                    sum += distances[distances.Count - 1];
                    distances[distances.Count - 1] = distances[0];
                }
                else
                {
                    temp = distances[index];
                    sum += distances[index];
                    distances.RemoveAt(index);
                }

                if (distances.Count == 0)
                {
                    break;
                }
                for (int i = 0; i < distances.Count; i++)
                {
                    if (distances[i] <= temp)
                    {
                        distances[i] += temp;
                    }
                    else
                    {
                        distances[i] -= temp;
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}
