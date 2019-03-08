using System;
using System.Numerics;

namespace _01AnonymousDownsite
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger securityKey = BigInteger.Parse(Console.ReadLine());

            decimal totalLoss = 0;
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string siteName = input[0];
                long siteVisits = long.Parse(input[1]);
                decimal pricePerVisit = decimal.Parse(input[2]);

                totalLoss += siteVisits * pricePerVisit;
                Console.WriteLine(siteName);
            }

            BigInteger securityToken = BigInteger.Pow(securityKey, n);

            Console.WriteLine($"Total Loss: {totalLoss:f20}");
            Console.WriteLine($"Security Token: {securityToken}");
        }
    }
}
