using System;
using System.Collections.Generic;
using System.Linq;

namespace _02CommandInterpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] tokens = input.Split();
                int startIndex = 0;
                int count = 0;

                if (tokens[0] == "reverse")
                {
                    startIndex = int.Parse(tokens[2]);
                    count = int.Parse(tokens[4]);

                    if (startIndex > list.Count - 1 || startIndex < 0 || startIndex + count > list.Count || startIndex + count < 0)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        continue;
                    }

                    GetReversed(list, startIndex, count);

                }
                else if (tokens[0] == "sort")
                {
                    startIndex = int.Parse(tokens[2]);
                    count = int.Parse(tokens[4]);

                    if (startIndex > list.Count - 1 || startIndex < 0 || startIndex + count > list.Count || startIndex + count < 0)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        continue;
                    }

                    GetSorted(list, startIndex, count);

                }
                else if (tokens[0] == "rollLeft")
                {
                    count = int.Parse(tokens[1]);

                    if (count < 0)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        continue;
                    }

                    GetLeftRoll(list, count);
                }
                else if (tokens[0] == "rollRight")
                {
                    count = int.Parse(tokens[1]);

                    if (count < 0)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        continue;
                    }

                    GetRightRoll(list, count);
                }
            }

            Console.WriteLine("[" + string.Join(", ", list) + "]");
        }

        private static void GetRightRoll(List<string> list, int count)
        {
            for (int i = 0; i < count % list.Count; i++)
            {
                string last = list[list.Count - 1];
                list.RemoveAt(list.Count - 1);
                list.Insert(0, last);
            }
        }

        private static void GetLeftRoll(List<string> list, int count)
        {
            for (int i = 0; i < count % list.Count; i++)
            {
                string first = list[0];
                list.RemoveAt(0);
                list.Add(first);
            }
        }

        private static void GetSorted(List<string> list, int startIndex, int count)
        {
            List<string> sorted = list.Skip(startIndex).Take(count).ToList();
            sorted.Sort();
            list.RemoveRange(startIndex, count);
            list.InsertRange(startIndex, sorted);
        }

        private static void GetReversed(List<string> list, int startIndex, int count)
        {
            List<string> reversed = list.Skip(startIndex).Take(count).ToList();
            reversed.Reverse();
            list.RemoveRange(startIndex, count);
            list.InsertRange(startIndex, reversed);

        }
    }
}
