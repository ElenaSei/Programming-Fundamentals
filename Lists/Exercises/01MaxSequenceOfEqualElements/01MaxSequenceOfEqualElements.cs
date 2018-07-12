using System;
using System.Collections.Generic;
using System.Linq;

namespace temp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            int bestNum = nums[0];
            int counter = 1;
            int maxCounter = 1;

            for (int i = nums.Count - 1; i > 0; i--)
            {
                if (nums[i] == nums[i - 1])
                {
                    counter++;
                    if (counter >= maxCounter)
                    {
                        maxCounter = counter;
                        bestNum = nums[i];
                    }
                }
                else
                {
                    counter = 1;
                }

            }

            for (int i = 0; i < maxCounter; i++)
            {
                Console.Write(bestNum + " ");
            }
        }
    }
}
