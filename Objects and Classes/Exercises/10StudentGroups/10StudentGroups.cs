using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _10StudentGroups
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Town> towns = new List<Town>();
            string input = Console.ReadLine();

            while (true)
            {
                if (input == "End")
                {
                    break;
                }
                string[] tokens = input.Split(" => ", StringSplitOptions.RemoveEmptyEntries);
                string townName = tokens[0];
                int capacity = int.Parse(tokens[1].Split()[0]);

                Town town = new Town();
                town.Name = townName;
                town.Capacity = capacity;
                town.Students = new List<Student>();
                towns.Add(town);

                input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                while (input.Contains('|'))
                {
                    tokens = input.Split('|', StringSplitOptions.RemoveEmptyEntries);
                    string name = tokens[0];
                    string mail = tokens[1].Trim();
                    DateTime date = DateTime.ParseExact(tokens[2].Trim(), "d-MMM-yyyy", CultureInfo.InvariantCulture);

                    Student student = new Student();
                    student.Name = name.Trim();
                    student.Email = mail.Trim();
                    student.RegistrationDate = date;

                    Town currentTown = towns.First(t => t.Name == townName);
                    currentTown.Students.Add(student);

                    input = Console.ReadLine();
                    if (input == "End")
                    {
                        break;
                    }
                }
            }
            List<Groups> groups = new List<Groups>();

            foreach (Town town in towns)
            {
                IEnumerable<Student> students = town.Students.OrderBy(s => s.RegistrationDate).ThenBy(s => s.Name).ThenBy(s => s.Email);

                while (students.Any())
                {
                    Groups group = new Groups();
                    group.Town = town.Name;
                    group.Students = students.Take(town.Capacity).ToList();
                    students = students.Skip(town.Capacity);
                    groups.Add(group);
                }
            }

            Console.WriteLine($"Created {groups.Count} groups in {towns.Count} towns:");

            foreach (var group in groups.OrderBy(g => g.Town))
            {
                Console.WriteLine($"{group.Town} => {string.Join(", ", group.Students.Select(s => s.Email).ToList())}");
            }
        }
    }
    class Groups
    {
        public string Town { get; set; }
        public List<Student> Students { get; set; }
    }
    class Student
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime RegistrationDate { get; set; }
    }
    class Town
    {
        public string Name { get; set; }
        public int Capacity { get; set; }
        public List<Student> Students { get; set; }
    }
}
