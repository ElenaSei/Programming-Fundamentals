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

            int index = 0;
            int element = 0;

            while (true)
            {
                string[] commands = Console.ReadLine().Split();

                if (commands[0] == "print")
                {
                    Console.WriteLine("[" + string.Join(", ", nums) + ']');
                    break;
                }
                if (commands[0] == "add")
                {
                    index = int.Parse(commands[1]);
                    element = int.Parse(commands[2]);
                    nums.Insert(index, element);
                }
                else if (commands[0] == "addMany")
                {
                    index = int.Parse(commands[1]);
                    var elements = commands.Skip(2).Select(int.Parse).ToArray();
                    nums.InsertRange(index, elements);
                }
                else if (commands[0] == "contains")
                {
                    element = int.Parse(commands[1]);

                    if (nums.Contains(element))
                    {
                        Console.WriteLine(nums.IndexOf(element));
                    }
                    else
                    {
                        Console.WriteLine("-1");
                    }

                }
                else if (commands[0] == "remove")
                {
                    index = int.Parse(commands[1]);
                    nums.RemoveAt(index);
                }
                else if (commands[0] == "shift")
                {
                    int position = int.Parse(commands[1]);
                    GetShift(nums, position);
                }
                else if (commands[0] == "sumPairs")
                {
                    SumPairs(nums);
                }
            }

        }

        private static void SumPairs(List<int> nums)
        {
            for (int i = 0; i < nums.Count - 1; i++)
            {
                nums[i] += nums[i + 1];
                nums.RemoveAt(i + 1);
            }
        }

        private static void GetShift(List<int> nums, int position)
        {
            position = position % nums.Count;

            for (int i = 0; i < position; i++)
            {
                int firstNum = nums[0];
                nums.RemoveAt(0);
                nums.Add(firstNum);
            }
        }
    }
}
