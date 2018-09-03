using System;

namespace _05ArraysLab
{
    class Program
    {
        static void Main(string[] args)
        {
            int dayNumber = int.Parse(Console.ReadLine());

            string[] dayNames = {"Monday", "Tuesday", "Wednesday", "Thursday",
                "Friday", "Saturday", "Sunday"};
            if (dayNumber > 0 && dayNumber <= 7)
            {
                Console.WriteLine(dayNames[dayNumber - 1]);
            }
            else
            {
                Console.WriteLine("Invalid Day!");
            }
        }
    }
}
