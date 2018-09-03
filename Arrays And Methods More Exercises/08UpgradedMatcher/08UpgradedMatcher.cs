using System;
using System.Linq;

namespace _08UpgradedMatcher
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
            double[] pricesOfProducts = Console.ReadLine()
                                                .Split(' ')
                                                .Select(double.Parse)
                                                .ToArray();
            bool done = true;
            long quantityOrdered = 0;
            double totalPrice = 0;
            while (done)
            {
                
                string[] product = Console.ReadLine()
                                          .Split(' ')
                                          .ToArray();
                if (product[0] == "done")
                {
                    done = false;
                    break;
                }
                quantityOrdered = long.Parse(product[1]);
                if (quantityOfProducts.Length - 1 < Array.IndexOf(nameOfProducts, product[0]) ||
                    quantityOfProducts[Array.IndexOf(nameOfProducts, product[0])] < quantityOrdered)
                {
                    Console.WriteLine($"We do not have enough {product[0]}");
                }
                else if (quantityOfProducts[Array.IndexOf(nameOfProducts, product[0])] >= quantityOrdered)
                {
                    totalPrice = pricesOfProducts[Array.IndexOf(nameOfProducts, product[0])] * quantityOrdered;
                    Console.WriteLine($"{product[0]} x {quantityOrdered} " +
                                      $"costs {totalPrice:f2}");
                    quantityOfProducts[Array.IndexOf(nameOfProducts, product[0])] -=
                        quantityOrdered;
                }
            }
        }
    }
}
