using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _01CountWorkingDays
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);

            DateTime[] holidays =
            {
                new DateTime(4, 1, 1), //тук задаваме примерна година, защото по условие не знаем каква ще е
                new DateTime(4, 3, 3),
                new DateTime(4, 5, 1),
                new DateTime(4, 5, 6),
                new DateTime(4, 5, 24),
                new DateTime(4, 9, 6),
                new DateTime(4, 9, 22),
                new DateTime(4, 11, 1),
                new DateTime(4, 12, 24),
                new DateTime(4, 12, 25),
                new DateTime(4, 12, 26)
            };

            int counter = 0;

            for (DateTime day = startDate; day <= endDate; day = day.AddDays(1))
            {
                if (day.DayOfWeek == DayOfWeek.Saturday || day.DayOfWeek == DayOfWeek.Sunday)
                {
                    continue;
                }

                //тук сетваме настоящата дата с примерната година, която сме задали в масива
                DateTime currentDate = new DateTime(4, day.Month, day.Day);

                if (holidays.Contains(currentDate) == false)
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
