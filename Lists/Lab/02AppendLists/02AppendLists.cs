using System;
using System.Collections.Generic;
using System.Linq;

namespace _02AppendLists
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> textLists = Console.ReadLine()
                                               .Split('|')
                                               .ToList();
            textLists.Reverse();
            foreach (var text in textLists)
            {
                
                string[] textArr = text.Split(new char[] { ' ' },
                           StringSplitOptions.RemoveEmptyEntries);
                string joined = string.Join(" ", textArr);
                Console.Write(joined + " ");
            }
            Console.WriteLine();


            // задачата решена чрез функционално програмиране
            /*List<List<string>> textLists = Console.ReadLine()
                                                  .Split('|')
                                                  .Reverse()
                                                  .Select(
                                                      s => s.Split(new char[] { ' ' },
                                                                   StringSplitOptions.RemoveEmptyEntries)
                                                      .ToList())
                                                  .ToList();
            foreach (var innerList in textLists)
            {
                foreach (var num in innerList)
                {
                    Console.Write(num + " ");
                }
            }
            */

        }

    }
}
