using System;
using System.Collections.Generic;
using System.Linq;

namespace _09TeamworkProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Projects> projects = new List<Projects>();

            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                string[] tokens = Console.ReadLine().Split('-');
                string creator = tokens[0];
                string team = tokens[1];

                bool projectExists = projects.Any(p => p.Team == team);
                bool userExists = projects.Any(p => p.Creator == creator);

                if (!projectExists && !userExists)
                {
                    Console.WriteLine($"Team {team} has been created by {creator}!");
                    Projects newProject = new Projects(team, creator);
                    projects.Add(newProject);
                }
                else if(projectExists)
                {
                    Console.WriteLine($"Team {team} was already created!");
                }
                else if(userExists)
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }
            }

            string input;
            while ((input = Console.ReadLine()) != "end of assignment")
            {
                string[] tokens = input.Split("->");
                string member = tokens[0];
                string team = tokens[1];

                bool teamExist = projects.Any(p => p.Team == team);
                bool memberExists = projects.Any(p => p.Creator == member || p.Members.Contains(member));

                if (!teamExist)
                {
                    Console.WriteLine($"Team {team} does not exist!");
                }
                else if (memberExists)
                {
                    Console.WriteLine($"Member {member} cannot join team {team}!");
                }
                else
                {
                    Projects project = projects.First(t => t.Team == team);
                    project.Members.Add(member);
                }
            }

            foreach (var project in projects.Where(p => p.Members.Count > 0).OrderByDescending(p => p.Members.Count).ThenBy(p => p.Team))
            {
                Console.WriteLine(project.Team);
                Console.WriteLine($"- {project.Creator}");
                foreach (var member in project.Members.OrderBy(m => m))
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            Console.WriteLine("Teams to disband:");

            foreach (var project in projects.Where(p => p.Members.Count == 0).OrderBy(p => p.Team))
            {
                Console.WriteLine(project.Team);
            }
        }
    }
    class Projects
    {
        public string Team { get; set; }
        public string Creator { get; set; }
        public List<string> Members { get; set; }

        public Projects(string team, string creator)
        {
            this.Team = team;
            this.Creator = creator;
            this.Members = new List<string>();
        }
    }
}
