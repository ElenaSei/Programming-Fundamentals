using System;

namespace _04MethodsDebuggingAndTroubleshootingCodeLab
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintHeader();
        }

        static void PrintHeader()
        {
            PrintTop();
            PrintBody();
            PrintBottom();
        }
        static void PrintTop()
        {
            Console.WriteLine("CASH RECEIPT\n------------------------------");
        }
        static void PrintBody()
        {
            Console.WriteLine("Charged to____________________\nReceived by___________________");
        }
        static void PrintBottom()
        {
            Console.WriteLine("------------------------------\n© SoftUni");
        }
    }
}
