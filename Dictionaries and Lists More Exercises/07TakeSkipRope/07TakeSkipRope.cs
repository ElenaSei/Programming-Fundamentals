using System;
using System.Collections.Generic;
using System.Linq;

namespace _07TakeSkipRope
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            List<int> digits = new List<int>();
            List<char> letters = new List<char>();

            foreach (var symbol in text)
            {
                if (char.IsDigit(symbol))
                {
                    int num = int.Parse(symbol.ToString());
                    digits.Add(num);
                }
                else
                {
                    letters.Add(symbol);
                }
            }
            List<int> takeList = new List<int>();
            List<int> skipList = new List<int>();
            for (int i = 0; i < digits.Count; i++)
            {
                if (i % 2 == 0)
                {
                    takeList.Add(digits[i]);
                }
                else
                {
                    skipList.Add(digits[i]);
                }
            }
            string result = "";
            var total = 0;
            for (int i = 0; i < takeList.Count; i++)
            {
                int skip = skipList[i];
                int take = takeList[i];
                result += new string(letters.Skip(total).Take(take).ToArray());
                total += skip + take;
            }
            Console.WriteLine(result);
        }
    }
}
