using System;
using System.Collections.Generic;
using System.Linq;

namespace _04SupermarketDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                                    .Split(' ')
                                    .ToArray();
            var supermarket = new Dictionary<string, List<double>>();
            string productName = "";
            double productPrice = 0;
            int productQuantity = 0;
            while (input[0] != "stocked")
            {
                productName = input[0];
                productPrice = double.Parse(input[1]);
                productQuantity = int.Parse(input[2]);

                if (!supermarket.ContainsKey(productName))
                {
                    var priceAndQuantity = new List<double>();
                    priceAndQuantity.Add(productPrice);
                    priceAndQuantity.Add(productQuantity);
                    supermarket.Add(productName, priceAndQuantity);
                }
                else if (!supermarket[productName].Contains(productPrice))
                {
                    supermarket[productName][0] = productPrice;
                    supermarket[productName][1] += productQuantity;
                }
                else
                {
                    supermarket[productName][1] += productQuantity;
                }

                input = Console.ReadLine().Split(' ').ToArray();
            }
            double total = 0;
            foreach (var item in supermarket)
            {
                Console.WriteLine($"{item.Key}: ${item.Value[0]:f2} * {item.Value[1]} = ${(item.Value[0] * item.Value[1]):f2}");
                total += (item.Value[0] * item.Value[1]);
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine($"Grand Total: ${total:f2}");
        }
    }
}
