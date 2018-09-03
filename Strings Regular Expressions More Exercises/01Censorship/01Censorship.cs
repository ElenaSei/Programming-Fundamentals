using System;
using System.Text;

namespace _01Censorship
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string sentence = Console.ReadLine();
            string censor = new string('*', word.Length);

            if (sentence.Contains(word))
            {
                sentence = sentence.Replace(word, censor);
            }
            Console.WriteLine(sentence);
        }
    }
}
