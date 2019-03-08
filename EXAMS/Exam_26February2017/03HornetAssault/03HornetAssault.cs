using System;
using System.Collections.Generic;
using System.Linq;

namespace _03HornetAssault
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> beehives = Console.ReadLine().Split().Select(long.Parse).ToList();
            List<long> hornets = Console.ReadLine().Split().Select(long.Parse).ToList();

            for (int i = 0; i < beehives.Count; i++)
            {
                if (hornets.Count == 0)
                {
                    break;
                }

                long hornetsPower = hornets.Sum();

                if (beehives[i] < hornetsPower)
                {
                    beehives[i] -= hornetsPower;
                }
                else if (beehives[i] >= hornetsPower)
                {
                    beehives[i] -= hornetsPower;
                    hornets.RemoveAt(0);
                }
            }

            beehives.RemoveAll(b => b <= 0);

            if (beehives.Count > 0)
            {
                Console.WriteLine(string.Join(" ", beehives.Where(b => b > 0)));
            }
            else
            {
                Console.WriteLine(string.Join(" ", hornets));
            }

        }
    }
}
