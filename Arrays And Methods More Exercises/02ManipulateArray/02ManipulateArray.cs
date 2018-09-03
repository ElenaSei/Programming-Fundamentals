using System;
using System.Linq;

namespace _02ManipulateArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine()
                                  .Split(' ')
                                  .ToArray();
            int lines = int.Parse(Console.ReadLine());
            string index = "";
            int indexInt = 0;
            for (int i = 0; i < lines; i++)
            {
                string[] command = Console.ReadLine()
                                          .Split(' ')
                                          .ToArray();
                for (int g = 0; g < command.Length; g++)
                {
                    if (command[0] == "Reverse")
                    {
                        Array.Reverse(arr);
                    }
                    else if (command[0] == "Distinct")
                    {
                        arr = arr.Distinct().ToArray();
                    }
                    else if(command[0] == "Replace")
                    {

                        index = command[1];
                        int.TryParse(index, out indexInt);
                        arr[indexInt] = command[2];
                    }
                }
            }
            Console.WriteLine(string.Join(", ", arr));
        }
    }
}
