using System;
using System.Collections.Generic;
using System.Linq;

namespace _04FixEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> namesEmails = new Dictionary<string, string>();
            string input;

            while ((input = Console.ReadLine()) != "stop")
            {
                string name = input;
                string email = Console.ReadLine();

                if (!email.EndsWith("us") && !email.EndsWith("uk") && !namesEmails.ContainsKey(name))
                {
                    namesEmails.Add(name, email);
                }
            }

            foreach (var kvp in namesEmails)
            {
                Console.WriteLine(kvp.Key + " -> " + kvp.Value);
            }
        }
    }
}
