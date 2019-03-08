using System;
using System.Collections.Generic;
using System.Linq;

namespace _02Snowmen
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int attacker = 0;
            int target = 0;
            int diff = 0;
            while (numbers.Count > 1)
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    List<int> helper = new List<int>(numbers);
                    helper.RemoveAll(n => n == 0);

                    if (helper.Count == 1) // numbers.Where(x => x > 0).Count() == 1
                    {
                        break;
                    }

                    attacker = i;
                    target = numbers[i];

                    if (target == 0)
                    {
                        continue;
                    }
                    if (target > numbers.Count - 1)
                    {
                        target = target % numbers.Count;
                    }

                    diff = Math.Abs(target - attacker);

                    if (diff == 0)
                    {
                        Console.WriteLine($"{i} performed harakiri");
                        numbers[i] = 0;
                    }
                    else if (diff % 2 == 0)
                    {
                        Console.WriteLine($"{attacker} x {target} -> {attacker} wins");
                        numbers[target] = 0;
                    }
                    else if (diff % 2 != 0)
                    {
                        Console.WriteLine($"{attacker} x {target} -> {target} wins");
                        numbers[i] = 0;
                    }
                }
                numbers.RemoveAll(n => n == 0);
            }
        }
    }
}
