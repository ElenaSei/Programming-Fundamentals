using System;
using System.Collections.Generic;
using System.Linq;

namespace _06ByteFlip
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bytes = Console.ReadLine()
                                    .Split(' ')
                                    .ToArray();
            List<string> output = new List<string>();
            for (int i = 0; i < bytes.Length; i++)
            {
                if (bytes[i].Length == 2)
                {
                    var helper = bytes[i].Reverse().ToArray();
                    output.Add(HEX2ASCII(new string(helper)));
                }
            }
            output.Reverse();
            Console.WriteLine(string.Join("", output));

        }
        static string HEX2ASCII(string hex)
        {
            string result = String.Empty;
            for (int i = 0; i < hex.Length - 1; i++)
            {
                string Char2Convert = hex.Substring(i, 2);
                int n = Convert.ToInt32(Char2Convert, 16);
                char c = (char)n;
                result += c.ToString();
            }
            return result;
        }
    }
}
