using System;
using System.Linq;
using System.Text;

namespace _06SumBigNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string num1 = Console.ReadLine();
            string num2 = Console.ReadLine();

            if (num1.Length > num2.Length)
            {
                num2 = num2.PadLeft(num1.Length, '0');
            }
            else if (num2.Length > num1.Length)
            {
                num1 = num1.PadLeft(num2.Length, '0');
            }
            int sum = 0;
            int reminder = 0;
            StringBuilder output = new StringBuilder();
            int num = 0;
            for (int i = num1.Length - 1; i >= 0; i--)
            {
                sum = num1[i] - 48 + num2[i] - 48 + reminder; //вадим ASCII таблицата от тях!
                num = sum % 10; // за да вземем само последната цифра
                output.Append(num);
                if (sum > 9)
                {
                    reminder = 1; // 1 наум
                }
                else
                {
                    reminder = 0;
                }
                if (i == 0 && reminder == 1)
                {
                    output.Append(reminder);
                }
            }
            Console.WriteLine(output.ToString().TrimEnd('0').ToCharArray().Reverse().ToArray());

        }
    }
}
