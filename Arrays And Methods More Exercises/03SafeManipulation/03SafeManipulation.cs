using System;
using System.Linq;

namespace _03SafeManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine()
                                  .Split(' ')
                                  .ToArray();
            string index = "";
            int indexInt = 0;
            bool end = true;
            while(end)
            {
                string[] command = Console.ReadLine()
                                          .Split(' ')
                                          .ToArray();
                for (int g = 0; g < 1; g++)
                {
                    if (command[0] == "Reverse")
                    {
                        Array.Reverse(arr);
                    }
                    else if (command[0] == "Distinct")
                    {
                        arr = arr.Distinct().ToArray();
                    }
                    else if (command[0] == "Replace")
                    {
                        index = command[1];
                        int.TryParse(index, out indexInt);
                        if (arr.Length - 1 >= indexInt && indexInt >= 0)
                        {
                            arr[indexInt] = command[2];
                        }
                        else
                        {
                            Console.WriteLine("Invalid input!");
                        }
                    }
                    else if (command[0] == "END")
                    {
                        end = false;
                    }
                    else
                    {
                            Console.WriteLine("Invalid input!");
                        
                    }
                }
            }
            Console.WriteLine(string.Join(", ", arr));
        }
    }
}
