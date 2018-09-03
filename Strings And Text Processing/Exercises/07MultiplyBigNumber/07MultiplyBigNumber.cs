using System;
using System.Linq;
using System.Text;

namespace _07MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string num1 = Console.ReadLine();
            int num2 = int.Parse(Console.ReadLine());

            if (num2 == 0)
            {
                Console.WriteLine("0");
                return;
            }

            int multiplyer = 0;
            int reminder = 0;
            StringBuilder output = new StringBuilder();
            int num = 0;
            for (int i = num1.Length - 1; i >= 0; i--)
            {
                multiplyer = (num1[i] - 48) * num2 + reminder; //вадим ASCII таблицата от тях!
                num = multiplyer % 10; // за да вземем само последната цифра
                output.Append(num);
                if (multiplyer > 9)
                {
                    reminder = multiplyer / 10;
                }
                else
                {
                    reminder = 0;
                }
                if (i == 0 && reminder != 0)
                {
                    output.Append(reminder);
                }
            }
            Console.WriteLine(output.ToString().TrimEnd('0').ToCharArray().Reverse().ToArray());

        }
    }
}
