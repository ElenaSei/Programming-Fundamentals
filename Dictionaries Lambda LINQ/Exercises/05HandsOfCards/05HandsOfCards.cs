using System;
using System.Collections.Generic;
using System.Linq;

namespace _05HandsOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> peopleHands = new Dictionary<string, List<string>>();
            string input;

            while ((input = Console.ReadLine()) != "JOKER")
            {
                string name = input.Split(':')[0];
                string[] cards = input.Split(new char[] { ' ', ':', ',' }, StringSplitOptions.RemoveEmptyEntries).Skip(1).ToArray();

                if (!peopleHands.ContainsKey(name))
                {
                    peopleHands.Add(name, new List<string>());
                }

                peopleHands[name].AddRange(cards);
                peopleHands[name] = peopleHands[name].Distinct().ToList();
            }

            foreach (var kvp in peopleHands)
            {
                Console.Write($"{kvp.Key}: ");

                int sum = GetSum(kvp.Value);

                Console.WriteLine(sum);
            }
        }

        private static int GetSum(List<string> cards)
        {
            int sum = 0;

            foreach (var hand in cards)
            {
                int power = 0;
                int type = 0;
                bool isDigit = int.TryParse(hand[0].ToString(), out power);

                if (hand.Length == 3)
                {
                    power = 10;
                }

                if (!isDigit)
                {
                    if (hand[0] == 'J')
                    {
                        power = 11;
                    }
                    else if (hand[0] == 'Q')
                    {
                        power = 12;
                    }
                    else if (hand[0] == 'K')
                    {
                        power = 13;
                    }
                    else if (hand[0] == 'A')
                    {
                        power = 14;
                    }
                }

                if (hand.Last() == 'S')
                {
                    type = 4;
                }
                else if (hand.Last() == 'H')
                {
                    type = 3;
                }
                else if (hand.Last() == 'D')
                {
                    type = 2;
                }
                else if (hand.Last() == 'C')
                {
                    type = 1;
                }

                sum += power * type;
            }
            return sum;
        }
    }
}
