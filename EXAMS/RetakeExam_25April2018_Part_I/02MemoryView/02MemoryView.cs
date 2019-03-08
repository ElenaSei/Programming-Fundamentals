using System;
using System.Collections.Generic;
using System.Linq;

namespace _02MemoryView
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> code = new List<string>();
            List<int> output = new List<int>();
            while (input != "Visual Studio crash")
            {
                code.AddRange(input.Split(' ').ToList());
                input = Console.ReadLine();
            }
            string code1 = "32656";
            string code2 = "19759";
            string code3 = "32763";
            for (int i = 0; i < code.Count; i++)
            {
                if (code[i] == code1 && code[i + 1] == code2 && code[i + 2] == code3)
                {
                    int size = int.Parse(code[i + 4]);
                    output = code.Skip(i + 6).Take(size).Select(x => int.Parse(x)).ToList();
                    string word = MakeWord(output);
                    Console.WriteLine(word);
                }
            }

        }

        private static string MakeWord(List<int> output)
        {
            char[] temp = new char[output.Count];
            for (int i = 0; i < output.Count; i++)
            {
                temp[i] = (char)(output[i]);
            }
            return new string(temp);
        }
    }
}
