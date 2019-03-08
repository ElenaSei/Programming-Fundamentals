using System;
using System.Linq;

namespace _02Ladybugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[] indexes = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string[] commands = Console.ReadLine().Split(' ').ToArray();
            int index = 0;
            string direction = "";
            int flyLength = 0;
            int[] field = new int[size];
            foreach (var item in indexes)
            {
                if (item < field.Length && item >= 0)
                {
                    field[item] = 1;
                }
            }
            while (commands[0] != "end")
            {
                index = int.Parse(commands[0]);
                direction = commands[1];
                flyLength = int.Parse(commands[2]);

                if (index < 0 || index > field.Length - 1 || field[index] == 0)
                {
                    commands = Console.ReadLine().Split(new char[] { ' ' }).ToArray();
                    continue;
                }

                field[index] = 0;

                if (direction == "right")
                {
                    if (index + flyLength > field.Length - 1)
                    {
                        continue;
                    }
                    else if (field[index + flyLength] == 1)
                    {
                        for (int i = index + flyLength; i < field.Length - flyLength; i+=flyLength)
                        {
                            if (field[i + flyLength] == 0)
                            {
                                field[i + flyLength] = 1;
                                break;
                            }
                        }
                    }
                    else if (field[index + flyLength] == 0)
                    {
                        field[index + flyLength] = 1;
                    }
                }
                else if (direction == "left")
                {
                    if (index - flyLength < 0)
                    {
                        continue;
                    }
                    if (field[index - flyLength] == 0)
                    {
                        field[index - flyLength] = 1;
                    }
                    else if (field[index - flyLength] == 1)
                    {
                        for (int i = index - flyLength; i >= 0 + flyLength; i-=flyLength)
                        {
                            if (field[i - flyLength] == 0)
                            {
                                field[i - flyLength] = 1;
                                break;
                            }
                        }
                    }
                }
                commands = Console.ReadLine().Split(new char[] { ' ' }).ToArray();
                }
            Console.WriteLine(string.Join(" ", field));
        }
    }
}