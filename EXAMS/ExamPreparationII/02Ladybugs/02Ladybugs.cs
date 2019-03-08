using System;
using System.Linq;

namespace _02Ladybugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int[] indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] field = new int[length];

            for (int i = 0; i < indexes.Length; i++)
            {
                int index = indexes[i];
                if (index >= 0 && index < field.Length)
                {
                    field[index] = 1;
                }
            }

            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] commands = input.Split();
                int ladybugIndex = int.Parse(commands[0]);
                string direction = commands[1];
                int flyLength = int.Parse(commands[2]);

                if (ladybugIndex < 0 || ladybugIndex >= field.Length || field[ladybugIndex] == 0)
                {
                    continue;
                }
                if (direction == "left")
                {
                    flyLength *= -1;
                }
                if (flyLength != 0)
                {
                    MoveLadybug(field, ladybugIndex, flyLength);
                }
            }

            Console.WriteLine(string.Join(" ", field));
        }

        private static void MoveLadybug(int[] field, int ladybugIndex, int flyLength)
        {
            int nextIndex = ladybugIndex + flyLength;

            if (nextIndex >= field.Length || nextIndex < 0)
            {
                field[ladybugIndex] = 0;
            }
            else
            {
                while (field[nextIndex] != 0)
                {
                    nextIndex += flyLength;
                    if (nextIndex >= field.Length || nextIndex < 0)
                    {
                        field[ladybugIndex] = 0;
                        break;
                    }
                }

                if (nextIndex < field.Length && nextIndex >= 0)
                {
                    field[ladybugIndex] = 0;
                    field[nextIndex] = 1;
                }
            }
        }
    }
}
