using System;

namespace _05._Temperature_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            printReceipt();
        }

        static void printReceipt()
        {
            printReceiptHeader();
            printReceiptBody();
            printReceiptFooter();
        }

        static void printReceiptHeader()
        {
            Console.WriteLine("CASH RECEIPT\n------------------------------");
        }

        static void printReceiptBody()
        {
            Console.WriteLine("Charged to____________________\nReceived by___________________");
        }

        static void printReceiptFooter()
        {
            Console.WriteLine("------------------------------\n© SoftUni");
        }
    }
}
