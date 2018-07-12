using System;
using System.Collections.Generic;
using System.Linq;

namespace _06UserLogs
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, int>> userLogs = new SortedDictionary<string, Dictionary<string, int>>();
            string input;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] tokens = input.Split(new string[] { "IP=", " message=", " user=" }, StringSplitOptions.RemoveEmptyEntries);
                string ip = tokens[0];
                string user = tokens[2];

                if (!userLogs.ContainsKey(user))
                {
                    userLogs.Add(user, new Dictionary<string, int>());
                }
                if (!userLogs[user].ContainsKey(ip))
                {
                    userLogs[user].Add(ip, 0);
                }
                userLogs[user][ip]++;
            }

            foreach (var kvp in userLogs)
            {
                Console.WriteLine($"{kvp.Key}:");
                string outputId = "";

                foreach (var pair in kvp.Value)
                {
                    outputId += pair.Key + " => " + pair.Value + ", ";
                }
                outputId = outputId.Remove(outputId.Length - 2);
                Console.WriteLine($"{outputId}.");
            }
        }
    }
}
