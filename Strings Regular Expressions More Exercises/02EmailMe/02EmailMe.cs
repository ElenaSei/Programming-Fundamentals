using System;
using System.Linq;

namespace _02EmailMe
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] email = Console.ReadLine().Split('@').ToArray();
            int sum1 = email[0].Select(x => (int)(x)).Sum();
            int sum2 = email[1].Select(x => (int)(x)).Sum();
            if (sum1 - sum2 >= 0)
            {
                Console.WriteLine("Call her!");
            }
            else
            {
                Console.WriteLine("She is not the one.");
            }
        }
    }
}
