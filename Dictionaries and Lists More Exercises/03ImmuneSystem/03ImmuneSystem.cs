using System;
using System.Collections.Generic;
using System.Linq;

namespace _03ImmuneSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int initialHealth = int.Parse(Console.ReadLine());
            string virus = Console.ReadLine();
            var viruses = new Dictionary<string, int>();
            int health = initialHealth;
            int virusStrength = 0;
            while (virus != "end")
            {
                virusStrength = virus.Select(x => (int)x).Sum() / 3;
                int time = virusStrength * virus.Length;
                if (!viruses.ContainsKey(virus))
                {
                    viruses.Add(virus, time);
                }
                else
                {
                    time = viruses[virus] / 3;
                }
                int timeMin = time / 60;
                int timeSec = time % 60;
                health -= time;
                Console.WriteLine($"Virus {virus}: {virusStrength} => {time} seconds");
                if (health > 0)
                {
                    Console.WriteLine(string.Format("{0} defeated in {1}m {2}s.", virus, timeMin, timeSec));
                    Console.WriteLine($"Remaining health: {health}");
                }
                else if (health <= 0)
                {
                    Console.WriteLine($"Immune System Defeated.");
                    break;
                }

                if (health + (health * 20 / 100) > initialHealth)
                {
                    health = initialHealth;
                }
                else
                {
                    health += (health * 20 / 100);
                }
                virus = Console.ReadLine();
                if (virus == "end")
                {
                    Console.WriteLine($"Final Health: {health}");
                    break;
                }
            }
        }
    }
}
