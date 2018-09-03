using System;

namespace _04.BeverageLabels
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            int energyContentPer100 = int.Parse(Console.ReadLine());
            int sugarContentPer100 = int.Parse(Console.ReadLine());

            double energyTotal = (double)(energyContentPer100) * volume / 100; //каствам int на double, за да не ми го закръгля, а да го направи с десетична запетая
            double sugarTotal = 1.0* sugarContentPer100 * volume / 100; //друг вариант на горното

            Console.WriteLine($"{volume}ml {name}:\r\n{energyTotal}kcal, {sugarTotal}g sugars");
        }
    }
}