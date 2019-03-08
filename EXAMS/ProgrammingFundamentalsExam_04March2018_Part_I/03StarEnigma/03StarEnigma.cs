using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _03StarEnigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfMessages = int.Parse(Console.ReadLine());

            string pattern = @"([AaSsTtRr])";
            string pattern2 = @"@(?<planet>[a-zA-Z]+)[^@\-!:>]*:(?<population>\d+)[^@\-!:>]*!(?<attack>[AD])![^@\-!:>]*->(?<soldiers>\d+)";
           
            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();

            for (int i = 1; i <= numOfMessages; i++)
            {
                string planetName = "";
                string attackType = "";
                string message = Console.ReadLine();
                var matches = Regex.Matches(message, pattern);
                int counter = 0;

                foreach (Match symbol in matches)
                {
                    counter++;
                }

                string decryptedMessage = "";
               
                foreach (var symbol in message)
                {
                    char temp = (char)(symbol - counter);
                    decryptedMessage += temp;
                }

                counter = 0;
                var matches2 = Regex.Match(decryptedMessage, pattern2);

                if (matches2.Success)
                {
                    planetName = matches2.Groups["planet"].Value;
                    attackType = matches2.Groups["attack"].Value;
                }

                    if (attackType == "A")
                    {
                        attackedPlanets.Add(planetName);
                    }
                    else if(attackType == "D")
                    {
                        destroyedPlanets.Add(planetName);
                    }
                }

            attackedPlanets.Sort();
            destroyedPlanets.Sort();

            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");

            foreach (var item in attackedPlanets)
            {
                Console.WriteLine($"-> {item}");
            }

            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");

            foreach (var item in destroyedPlanets)
            {
                Console.WriteLine($"-> {item}");
            }
        }
    }
}
