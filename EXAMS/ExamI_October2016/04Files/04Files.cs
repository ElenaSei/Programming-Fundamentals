using System;
using System.Collections.Generic;
using System.Linq;

namespace _04Files
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            var rootFileSize = new Dictionary<string, Dictionary<string, long>>();

            for (int i = 0; i < lines; i++)
            {
                string[] input = Console.ReadLine().Split(new char[] { '\\', ';' });
                string root = input[0];
                string fileName = input[input.Length - 2];
                long fileSize = long.Parse(input[input.Length - 1]);

                if (!rootFileSize.ContainsKey(root))
                {
                    rootFileSize.Add(root, new Dictionary<string, long>());
                }
                if (!rootFileSize[root].ContainsKey(fileName))
                {
                    rootFileSize[root].Add(fileName, 0);
                }
                rootFileSize[root][fileName] = fileSize;
            }

            string[] searchedFile = Console.ReadLine().Split(new string[] { " in " }, StringSplitOptions.RemoveEmptyEntries);

            if (!rootFileSize.ContainsKey(searchedFile[1]))
            {
                Console.WriteLine("No");
            }
            else
            {
                var sortedResult = rootFileSize[searchedFile[1]]
                    .Where(x => x.Key.EndsWith(searchedFile[0]))
                    .OrderByDescending(x => x.Value)
                    .ThenBy(x => x.Key)
                    .ToDictionary(x => x.Key, x => x.Value);
                if (sortedResult.Count > 0)
                {
                    foreach (var item in sortedResult)
                    {
                        Console.WriteLine(item.Key + " - " + item.Value + " KB");
                    }
                }
                else
                {
                    Console.WriteLine("No");
                }
              
            }
        }
    }
}
