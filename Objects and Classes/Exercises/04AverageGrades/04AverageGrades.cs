using System;
using System.Collections.Generic;
using System.Linq;

namespace _04AverageGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfStudents = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int i = 0; i < numOfStudents; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                List<double> grades = new List<double>();
                grades = input.Skip(1).Select(double.Parse).ToList();

                Student student = new Student(name, grades);

                students.Add(student);
            }

            students = students.Where(s => s.AverageGrade >= 5).OrderBy(s => s.Name).ThenByDescending(s => s.AverageGrade).ToList();

            foreach (var student in students)
            {
                Console.WriteLine($"{student.Name} -> {student.AverageGrade:f2}");
            }
        }
    }

class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }
        public double AverageGrade { get; set; }

        public Student(string name, List<double> grade)
        {
            this.Name = name;
            this.Grades = grade;
            this.AverageGrade = grade.Average();
        }

    }
}
