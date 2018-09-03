using System;
using System.Linq;

namespace _06Heists
{
    class Program
    {
        static void Main(string[] args)
        {
            bool jailTime = true;
            string stringToCheck = "Jail Time";
            int goldPrice = 0;
            int jewelsPrice = 0;
            int totalGold = 0;
            int totalJewels = 0;
            int expenses = 0;
            string[] prices = Console.ReadLine()
                                       .Split(' ')
                                       .ToArray();
            for (int i = 0; i < prices.Length; i++)
            {
                if (i == 0)
                {
                    jewelsPrice = int.Parse(prices[i]);
                }
                else if (i == 1)
                {
                    goldPrice = int.Parse(prices[i]);
                }
            }
            
            while (jailTime)
            {
                string[] elements = Console.ReadLine()
                                       .Split(' ')
                                       .ToArray();
                if (elements.Any(stringToCheck.Contains))
                {
                    jailTime = false;
                    break;
                }
                foreach (char item in elements[0])
                {
                    if (item == '%')
                    {
                        totalJewels += jewelsPrice;
                    }
                    if (item == '$')
                    {
                        totalGold += goldPrice;
                    }
                }
                expenses += int.Parse(elements[1]);
            }
            int diff = Math.Abs(totalGold + totalJewels - expenses);
            if (expenses <= totalGold + totalJewels)
            {
                Console.WriteLine($"Heists will continue. Total earnings: {diff}.");
            }
            else
            {
                Console.WriteLine($"Have to find another job. Lost: {diff}.");
            }
        }
    }
}
