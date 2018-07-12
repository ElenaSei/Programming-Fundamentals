using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _08MentorGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Students> students = new List<Students>();

            string input;
            while ((input = Console.ReadLine())!= "end of dates")
            {
                string[] tokens = input.Split(" ,".ToCharArray(),StringSplitOptions.RemoveEmptyEntries);
                string studentName = tokens[0];

                List<DateTime> dates = new List<DateTime>();
                for (int i = 1; i < tokens.Length; i++)
                {
                    DateTime date = DateTime.ParseExact(tokens[i], "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    dates.Add(date);
                }

                Students student = students.FirstOrDefault(s => s.Name == studentName);
                if (student == null)
                {
                    Students newStudent = new Students(studentName);
                    newStudent.Date.AddRange(dates);
                    students.Add(newStudent);
                }
                else
                {
                    student.Date.AddRange(dates);
                }
            }

            string inputComments;
            while ((inputComments = Console.ReadLine()) != "end of comments")
            {
                string[] tokens = inputComments.Split('-');
                string studentName = tokens[0];

                List<string> comments = new List<string>();
                string comment = tokens[1];
                comments.Add(comment);

                Students currentStudent = students.FirstOrDefault(s => s.Name == studentName);
                if (currentStudent != null)
                {
                    currentStudent.Comments.AddRange(comments);
                }
            }

            foreach (var student in students.OrderBy(s => s.Name))
            {
                Console.WriteLine(student.Name);
                Console.WriteLine("Comments:");
                foreach (var comment in student.Comments)
                {
                    Console.WriteLine($"- {comment}");
                }
                Console.WriteLine("Dates attended:");
                foreach (var date in student.Date.OrderBy(d => d.Date))
                {
                    Console.WriteLine($"-- {date:dd/MM/yyyy}");
                }
            }
        }
    }
    class Students
    {
        public string Name { get; set; }
        public List<DateTime> Date { get; set; }
        public List<string> Comments { get; set; }

        public Students(string name)
        {
            this.Name = name;
            this.Date = new List<DateTime>();
            this.Comments = new List<string>();
        }
    }
}
