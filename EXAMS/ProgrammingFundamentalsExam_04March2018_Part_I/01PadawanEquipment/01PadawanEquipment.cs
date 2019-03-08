using System;

namespace _01PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyIvan = double.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            double saberPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());
            double saberPerc = studentsCount * 0.10;
            double moneyNeeded = saberPrice * (studentsCount + Math.Ceiling(saberPerc)) + robePrice * (studentsCount) +
                beltPrice * (studentsCount - (studentsCount / 6));

            if (moneyNeeded <= moneyIvan)
            {
                Console.WriteLine($"The money is enough - it would cost {moneyNeeded:f2}lv.");
            }
            else
            {
                double diff = moneyNeeded - moneyIvan;
                Console.WriteLine($"Ivan Cho will need {diff:f2}lv more.");
            }
        }
    }
}
