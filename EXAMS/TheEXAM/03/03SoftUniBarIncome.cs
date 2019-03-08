using System;
using System.Text.RegularExpressions;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^%(?<customer>[A-Z][a-z]+)%[^|$%.]*<(?<product>[\w]+)>[^|$%.]*\|(?<count>\d+)\|[^|$%.]*?(?<price>\d+(|.\d+))\$$";

            double totalIncome = 0;

            string input;
            while ((input = Console.ReadLine())!= "end of shift")
            {
                var matches = Regex.Match(input, pattern);

                if (Regex.IsMatch(input, pattern))
                {
                    string customer = matches.Groups["customer"].Value;
                    string product = matches.Groups["product"].Value;
                    int count = int.Parse(matches.Groups["count"].Value);
                    double price = double.Parse(matches.Groups["price"].Value);

                    double totalPrice = count * price;
                    totalIncome += totalPrice;

                    Console.WriteLine($"{customer}: {product} - {totalPrice:f2}");
                }
            }
            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }
}
