using System;
using System.Linq;

namespace _07InventoryMatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nameOfProducts = Console.ReadLine()
                                             .Split(' ')
                                             .ToArray();
            long[] quantityOfProducts = Console.ReadLine()
                                               .Split(' ')
                                               .Select(long.Parse)
                                               .ToArray();
            decimal[] pricesOfProducts = Console.ReadLine()
                                                .Split(' ')
                                                .Select(decimal.Parse)
                                                .ToArray();
            bool done = true;
            while (done)
            {
                string product = Console.ReadLine();
                if (product == "done")
                {
                    break;
                }
                Console.WriteLine($"{product} " +
                                  $"costs: {pricesOfProducts[Array.IndexOf(nameOfProducts, product)]}; " +
                                  $"Available quantity: {quantityOfProducts[Array.IndexOf(nameOfProducts, product)]}");
            }
        }
    }
}
