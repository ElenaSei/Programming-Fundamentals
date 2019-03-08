using System;
using System.Collections.Generic;
using System.Linq;

namespace _04RoliTheCoder
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> idEvents = new Dictionary<int, string>();
            Dictionary<string, List<string>> events = new Dictionary<string, List<string>>();

            string input;
            while ((input = Console.ReadLine())!= "Time for Code")
            {
                string[] tokens = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int id = int.Parse(tokens[0]);
                string @event = tokens[1];
                List<string> participants = new List<string>();
                bool isInvalid = false;
                for (int i = 2; i < tokens.Length; i++)
                {
                    string participant = tokens[i];

                    if (!participant.StartsWith("@"))
                    {
                        isInvalid = true;
                        break;
                    }
                    participants.Add(participant);
                }
                if (@event.StartsWith("#") && !idEvents.ContainsKey(id))
                {
                    idEvents.Add(id, @event);
                    events.Add(@event, new List<string>());
                }
                if (idEvents.ContainsKey(id) && idEvents[id] == @event && isInvalid == false)
                {
                    events[@event].AddRange(participants);
                    events[@event] = events[@event].Distinct().ToList();
                }
            }

            var sortedDict = events.OrderByDescending(e => e.Value.Count).ThenBy(e => e.Key);

            foreach (var kvp in sortedDict)
            {
                Console.WriteLine(kvp.Key.Remove(0, 1) + " - " + kvp.Value.Count);

                foreach (var participant in kvp.Value.OrderBy(p => p))
                {
                    Console.WriteLine(participant);
                }
            }
        }
    }
}
