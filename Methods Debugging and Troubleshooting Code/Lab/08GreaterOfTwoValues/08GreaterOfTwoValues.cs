using System;

namespace _08GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string first = Console.ReadLine();
            string second = Console.ReadLine();
            if (type == "string")
            {
                Console.WriteLine(GetMax(first, second));
            }
            else if (type == "char")
            {
                Console.WriteLine(GetMax(char.Parse(first), char.Parse(second)));
            }
            else if (type == "int")
            {
                Console.WriteLine(GetMax(int.Parse(first), int.Parse(second)));
            }
        }

        static int GetMax(int first, int second)
        {
            if (first >= second)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
        static char GetMax(char first, char second)
        {
            if (first >= second)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
        static string GetMax(string first, string second)
        {
            if (first.CompareTo(second) >= 0)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
    }
}
