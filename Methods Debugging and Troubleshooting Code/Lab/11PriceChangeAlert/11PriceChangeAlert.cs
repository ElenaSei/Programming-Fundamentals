using System;

class PriceChangeAlert
{
    static void Main()
    {
        int numOfPrices = int.Parse(Console.ReadLine());
        double significance = double.Parse(Console.ReadLine());
        double oldPrice = 0;

        for (int i = 1; i <= numOfPrices; i++)
        {
            double price = double.Parse(Console.ReadLine());
            if (i > 1)
            {
                double diff = GetDifference(oldPrice, price);
                bool isSignificantDifference = IsDiff(diff, significance);

                string message = Get(price, oldPrice, diff, isSignificantDifference);
                Console.WriteLine(message);
            }
            oldPrice = price;
        }
    }

    static string Get(double newPrice, double oldPrice, double diff, bool majorChange)
    {
        string message = "";
        if (diff == 0)
        {
            message = string.Format("NO CHANGE: {0}", newPrice);
        }
        else if (!majorChange)
        {
            message = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", oldPrice, newPrice, diff * 100);
        }
        else if (majorChange && (diff > 0))
        {
            message = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", oldPrice, newPrice, diff * 100);
        }
        else if (majorChange && (diff < 0))
            message = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", oldPrice, newPrice, diff * 100);
        return message;
    }
    static bool IsDiff(double difference, double significance)
    {
        if (Math.Abs(difference) >= significance)
        {
            return true;
        }
        return false;
    }

    static double GetDifference(double oldPrice, double newPrice)
    {
        double diff = (newPrice - oldPrice) / oldPrice;
        return diff;
    }
}
