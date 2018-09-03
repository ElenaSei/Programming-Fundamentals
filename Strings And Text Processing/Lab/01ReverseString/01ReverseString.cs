using System;

namespace _01ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            char[] reversedWord = word.ToCharArray();
            Array.Reverse(reversedWord);
            Console.WriteLine(reversedWord);
        }
    }
}
