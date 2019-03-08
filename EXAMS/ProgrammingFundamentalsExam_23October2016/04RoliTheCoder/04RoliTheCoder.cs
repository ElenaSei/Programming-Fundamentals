using System;
using System.Collections.Generic;
using System.Linq;

namespace _04RoliTheCoder
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string eventName = "";
            int id = 0;
            Dictionary<int, Dictionary<string, List<string>>> eventsInfo = new Dictionary<int, Dictionary<string, List<string>>>();

            while (input != "Time for Code")
            {
                string[] events = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                List<string> participants = new List<string>();
                bool invalidParticipants = false;

                for (int i = 2; i < events.Length; i++)
                {
                    if (!events[i].StartsWith("@"))
                    {
                        invalidParticipants = true;
                        break;
                    }
                    participants.Add(events[i]);
                }
                participants = participants.Distinct().ToList();

                if (events[1].StartsWith("#") && int.TryParse(events[0], out id) && !invalidParticipants)
                {
                    id = int.Parse(events[0]);
                    eventName = events[1].Remove(0, 1);

                    if (eventsInfo.ContainsKey(id) && eventsInfo[id].ContainsKey(eventName))
                    {
                        foreach (var participant in participants)
                        {
                            if (!eventsInfo[id][eventName].Contains(participant))
                            {
                                eventsInfo[id][eventName].Add(participant);
                            }
                        }
                    }
                    else if (!eventsInfo.ContainsKey(id))
                    {
                        Dictionary<string, List<string>> eventsParticipants = new Dictionary<string, List<string>>();
                        eventsParticipants.Add(eventName, participants);
                        eventsInfo.Add(id, eventsParticipants);

                    }
                }
                input = Console.ReadLine();
            }

            foreach (var pair in eventsInfo.OrderByDescending(x => x.Value.Values.Sum(p => p.Count)).ThenBy(y => y.Key))
            {
                foreach (var item in pair.Value)
                {
                    Console.WriteLine($"{item.Key} - {item.Value.Count()}");
                    foreach (var participants in item.Value.OrderBy(x => x))
                    {
                        Console.WriteLine(participants);
                    }
                }
            }
        }
    }
}
