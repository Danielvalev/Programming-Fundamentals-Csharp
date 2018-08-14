using System;

namespace _04._Numbers_in_Reversed_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberStr = Console.ReadLine();

            ReversedNumber(numberStr);
        }
        static void ReversedNumber(string numberStr)
        {
            string result = "";
            char symbol = '\0';
            for (int i = numberStr.Length - 1; i >= 0; i--)
            {
                symbol = numberStr[i];
                result += symbol;
            }

            Console.WriteLine(result);
        }
    }
}
