using System;

namespace _03PrintingTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            //    int num = int.Parse(Console.ReadLine());
            //    for (int i = 0; i < num; i++)
            //    {
            //        PrintLine(1, i);
            //    }
            //    PrintLine(1, num);
            //    for (int i = num - 1; i >= 0; i--)
            //    {

            //    }

            //}
            //static void PrintLine(int start, int end)
            //{
            //    for (int i = start; i <= end; i++)
            //    {
            //        Console.Write(i + " ");

            //    }
            //    Console.WriteLine();
            //}

            int cols = int.Parse(Console.ReadLine());

            PrintTrinagle(cols);
        }

        static void PrintTrinagle(int cols)
        {
            PrintTop(cols);
            PrintBottom(cols);
        }

        static void PrintTop(int cols)
        {
            for (int row = 1; row <= cols; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(col + " ");
                }
                Console.WriteLine();
            }
        }

        static void PrintBottom(int cols)
        {
            for (int row = cols - 1; row >= 1; row--)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(col + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
