using System;

namespace _12MasterNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                PrintMasterNumbers(i);
            }
        }

        static void PrintMasterNumbers(int number)
        {
            if (GetSymmetricNums(number) && GetDivisibleBy7Nums(number) && GetNumWithOneEvenDigit(number))
            {
                Console.WriteLine(number);
            }
        }

        static bool GetNumWithOneEvenDigit(int number)
        {
            int reminder = 0;
            bool evenDigit = false;
                while (number > 0)
                {
                    reminder = number % 10;
                    number = number / 10;
                    if (reminder % 2 == 0)
                    {
                     evenDigit = true;
                    }
                }
            return evenDigit;

        }

        static bool GetDivisibleBy7Nums(int number)
        {
            int sum = 0;
            int reminder = 0;
            bool divisibleNum = false;
            while (number > 0)
                {
                    reminder = number % 10;
                    number = number / 10;
                    sum += reminder;
                }
                if (sum % 7 == 0)
                {
                divisibleNum = true;
                }
            return divisibleNum;
        }


        static bool GetSymmetricNums(int number)
        {
            string numberAsString = Convert.ToString(number);
            string reversedNum = "";

            for (int i = numberAsString.Length - 1; i >= 0; i--)
            {
                reversedNum += numberAsString[i];
            }
            if (reversedNum == numberAsString)
                {
                    return true;
                }
            return false;
        }
    }
}
