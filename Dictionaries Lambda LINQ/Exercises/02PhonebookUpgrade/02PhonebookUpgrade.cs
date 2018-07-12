using System;
using System.Collections.Generic;
using System.Linq;

namespace _02PhonebookUpgrade
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();
            string input;

            while ((input = Console.ReadLine()) != "END")
            {
                string[] tokens = input.Split();
                string command = tokens[0];

                if (command == "A")
                {
                    string name = tokens[1];
                    string number = tokens[2];

                    if (!phonebook.ContainsKey(name))
                    {
                        phonebook.Add(name, "");
                    }

                    phonebook[name] = number;
                }
                else if (command == "S")
                {
                    string name = tokens[1];
                    if (phonebook.ContainsKey(name))
                    {
                        Console.WriteLine(name + " -> " + phonebook[name]);
                    }
                    else
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                }
                else if (command == "ListAll")
                {
                    foreach (var kvp in phonebook)
                    {
                        Console.WriteLine(kvp.Key + " -> " + kvp.Value);
                    }
                }
            }
            }
        }
    }
}
