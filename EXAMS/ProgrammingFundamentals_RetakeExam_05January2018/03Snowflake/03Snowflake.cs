using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03Snowflake
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = new string[5];

            for (int i = 0; i < 5; i++)
            {
                input[i] = Console.ReadLine();
            }

            string core = "";
            string pattern = @"^([^A-Za-z\d]+)([\d_]+)(?<core>[A-Za-z]+)([\d_]+)([^A-Za-z\d]+)$";
            bool isValid = true;

            while (true)
            {
                foreach (var symbol in input[0])
                {
                    if (char.IsDigit(symbol) || char.IsLetter(symbol))
                    {
                        isValid = false;
                        break;
                    }
                }

                foreach (var symbol in input[1])
                {
                    if (!(char.IsDigit(symbol)) && symbol != '_')
                    {
                        isValid = false;
                        break;
                    }
                }

                var match = Regex.Match(input[2], pattern);

                if (!match.Success)
                {
                    isValid = false;
                    break;
                }
                else
                {
                    core = match.Groups["core"].Value;
                }

                foreach (var symbol in input[3])
                {
                    if (!char.IsDigit(symbol) && symbol != '_')
                    {
                        isValid = false;
                        break;
                    }
                }

                foreach (var symbol in input[4])
                {
                    if (char.IsDigit(symbol) || char.IsLetter(symbol))
                    {
                        isValid = false;
                        break;
                    }
                }

                break;
            }
            if (isValid)
            {
                Console.WriteLine("Valid");
                Console.WriteLine(core.Length);
            }
            else
            {
                Console.WriteLine("Invalid");
            }
            /*
             * string patternSurface = @"^(?<surface>[^\dA-Za-z]+)$";
            string patternMantle = @"^(?<mantle>[\d_]+)$";
            string patternAll = @"^[^\dA-Za-z]+[\d_]+(?<core>[A-Za-z]+)[\d_]+[^\dA-Za-z]+$";

            bool isValid = true;
            string validText = "";
            for (int i = 1; i <= 5; i++)
            {
                string input = Console.ReadLine();

                if (i == 1 || i == 5)
                {
                    if (!Regex.IsMatch(input, patternSurface))
                    {
                        isValid = false;
                    }
                }
                else if (i == 2 || i == 4)
                {
                    if (!Regex.IsMatch(input, patternMantle))
                    {
                        isValid = false;
                    }
                }
                else if (i == 3)
                {
                    validText = input;
                    if (!Regex.IsMatch(input, patternAll))
                    {
                        isValid = false;
                    }
                }
            }

            if (isValid)
            {
                Console.WriteLine("Valid");
                Console.WriteLine(Regex.Match(validText, patternAll).Groups["core"].Length);
            }
            else
            {
                Console.WriteLine("Invalid");
            }
             */
        }
    }
}
