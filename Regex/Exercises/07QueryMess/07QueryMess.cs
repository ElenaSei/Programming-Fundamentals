using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _07QueryMess
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { '&', '?' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string pattern = @"((%20|\+)+)";
            while (input[0] != "END")
            {
                Dictionary<string, List<string>> results = new Dictionary<string, List<string>>();
                for (int i = 0; i < input.Length; i++)
                {
                    string[] temp = input[i].Split('=');
                    string field = temp[0];
                    field = Regex.Replace(field, pattern, word => " ").Trim();
                    if (temp.Length > 1)
                    {
                        string value = temp[1];
                        value = Regex.Replace(value, pattern, word => " ").Trim();
                        if (!results.ContainsKey(field))
                        {
                            List<string> values = new List<string>();
                            values.Add(value);
                            results.Add(field, values);
                        }
                        else
                        {
                            results[field].Add(value);
                        }
                    }
                }
                foreach (var pair in results)
                {
                    string values = string.Join(", ", pair.Value);
                    Console.Write($"{pair.Key}=[{values}]");
                }
                Console.WriteLine();
                input = Console.ReadLine().Split(new char[] { '&', '?' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            }


        }
    }
}
