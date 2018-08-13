using System;

namespace _07._Exchange_Variable_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputLine1 = int.Parse(Console.ReadLine());
            int inputLine2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Before:");
            Console.WriteLine($"a = {inputLine1}");
            Console.WriteLine($"b = {inputLine2}");

            // Exchange variable values
            int temp = inputLine1;
            inputLine1 = inputLine2;
            inputLine2 = temp;

            Console.WriteLine("After:");
            Console.WriteLine($"a = {inputLine1}");
            Console.WriteLine($"b = {inputLine2}");


        }
    }
}
