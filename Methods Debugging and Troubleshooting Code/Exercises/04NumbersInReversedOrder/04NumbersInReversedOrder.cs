using System;

namespace _04NumbersInReversedOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            string reversedNumber = GetReversedNumber(number);
            Console.WriteLine(reversedNumber);
        }

        static string GetReversedNumber(string number)
        {
            string reversedNumber = "";

            foreach (var item in number)
            {
                reversedNumber = item + reversedNumber;
            }

            return reversedNumber;
        }
    }
}
