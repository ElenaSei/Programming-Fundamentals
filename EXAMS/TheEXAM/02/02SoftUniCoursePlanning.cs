using System;
using System.Collections.Generic;
using System.Linq;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> schedule = Console.ReadLine().Split(", ").ToList();

            string input;
            while ((input = Console.ReadLine()) != "course start")
            {
                string[] tokens = input.Split(':');
                string command = tokens[0];

                string lesson = tokens[1];

                if (command == "Add")
                {
                    if (!schedule.Contains(lesson))
                    {
                        schedule.Add(lesson);
                    }
                }
                else if (command == "Insert")
                {
                    int index = int.Parse(tokens[2]);
                    if (!schedule.Contains(lesson))
                    {
                        schedule.Insert(index, lesson);
                    }
                }

                else if (command == "Remove")
                {
                    if (schedule.Contains(lesson))
                    {
                        schedule.Remove(lesson);
                    }
                }
                else if (command == "Swap")
                {
                    string secondLesson = tokens[2];

                    if (schedule.Contains(lesson) && schedule.Contains(secondLesson))
                    {
                        int index1 = schedule.IndexOf(lesson);
                        int index2 = schedule.IndexOf(secondLesson);
                        string l1 = schedule.ElementAt(index1);
                        string l2 = schedule.ElementAt(index2);

                        schedule[index1] = l2;
                        schedule[index2] = l1;

                        if (index1 + 1 < schedule.Count && schedule[index1 + 1].Contains(lesson))
                        {
                            schedule.Insert(index2 + 1, schedule[index1 + 1]);
                            schedule.RemoveAt(index1 + 2);
                        }
                        if (index2 + 1 < schedule.Count && schedule[index2 + 1].Contains(secondLesson))
                        {
                            schedule.Insert(index1 + 1, schedule[index2 + 1]);
                            schedule.RemoveAt(index2 + 2);
                        }

                    }
                }
                else if (command == "Exercise")
                {
                    if (schedule.Contains(lesson) && !schedule.Contains(lesson + "-Exercise"))
                    {
                        int index = schedule.IndexOf(lesson);
                        schedule.Insert(index + 1, lesson + "-Exercise");
                    }
                    else if (!schedule.Contains(lesson))
                    {
                        schedule.Add(lesson);
                        schedule.Add(lesson + "-Exercise");
                    }
                }
            }
            int count = 1;

            foreach (var item in schedule)
            {
                Console.WriteLine($"{count++}.{item}");
            }
        }
    }
}
