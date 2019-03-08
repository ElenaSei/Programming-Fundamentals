using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02HornetComm
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> broadcasts = new List<string>();
            List<string> messages = new List<string>();

            Regex message = new Regex(@"^([\d]+) <-> [\dA-Za-z]+$");
            Regex broadcast = new Regex(@"^([^\d]+) <-> [\dA-Za-z]+$");

            string input;
            while ((input = Console.ReadLine()) != "Hornet is Green")
            {
                string[] tokens = input.Split(new string[] { " <-> " }, StringSplitOptions.RemoveEmptyEntries);
                string result = "";

                if (message.IsMatch(input))
                {
                    string code = string.Join("", tokens[0].ToCharArray().Reverse());
                    result = code + " -> " + tokens[1];
                    messages.Add(result);
                }
                else if (broadcast.IsMatch(input))
                {
                    string frequency = GetChangedLetters(tokens[1]);
                    result = frequency + " -> " + tokens[0];
                    broadcasts.Add(result);
                }
            }

            Console.WriteLine("Broadcasts:");
            if (broadcasts.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                foreach (var item in broadcasts)
                {
                    Console.WriteLine(item);
                }
            }
            Console.WriteLine("Messages:");
            if (messages.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                foreach (var item in messages)
                {
                    Console.WriteLine(item);
                }
            }

        }

        private static string GetChangedLetters(string second)
        {
            string result = "";
            foreach (var symbol in second)
            {
                if (char.IsLower(symbol))
                {
                    result += symbol.ToString().ToUpper();
                }
                else if(char.IsUpper(symbol))
                {
                    result += symbol.ToString().ToLower();
                }
                else
                {
                    result += symbol;
                }
            }
            return result;
        }
    }
}
