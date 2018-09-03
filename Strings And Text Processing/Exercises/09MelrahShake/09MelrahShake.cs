using System;

namespace _09MelrahShake
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = Console.ReadLine();

            while (true)
            {
                int firstIndex = text.IndexOf(pattern);
                int lastIndex = text.LastIndexOf(pattern);

                if (firstIndex == - 1 || firstIndex == lastIndex || pattern.Length == 0)
                {
                    Console.WriteLine("No shake.");
                    break;
                }
                else
                {
                    text = text.Remove(lastIndex, pattern.Length);
                    text = text.Remove(firstIndex, pattern.Length);
                    pattern = pattern.Remove(pattern.Length / 2, 1);
                    Console.WriteLine("Shaked it.");
                }
            }
            Console.WriteLine(text);
        }
    }
}
