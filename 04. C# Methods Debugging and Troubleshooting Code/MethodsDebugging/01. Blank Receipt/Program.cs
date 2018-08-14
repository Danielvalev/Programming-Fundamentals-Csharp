using System;

namespace _01._Blank_Receipt
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
