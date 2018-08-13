using System;

namespace _07._Cake_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var count = 0;

            while ("Bake!" != input)
            {
                Console.WriteLine($"Adding ingredient {input}.");
                input = Console.ReadLine();
                count++;
            }
            Console.WriteLine($"Preparing cake with {count} ingredients.");
        }
    }
}
