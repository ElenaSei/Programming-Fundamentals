using System;
using System.Linq;

namespace _04CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ').ToArray();
            string w1 = words[0];
            string w2 = words[1];
            int sum = 0;
            for (int i = 0; i < Math.Min(w1.Length, w2.Length); i++)
            {
                sum += w1[i] * w2[i];
            }
            for (int i = Math.Min(w1.Length, w2.Length); i < Math.Max(w1.Length, w2.Length); i++)
            {
                try
                {
                    sum += w1[i];
                }
                catch
                {
                    sum += w2[i];
                }
                /*
                 * f (str1.Length > str2.Length)
                {
                    sum += str1[i];
                }
                else if (str1.Length < str2.Length)
                {
                    sum += str2[i];
                }
                */
            }
            Console.WriteLine(sum);
        }
    }
}
