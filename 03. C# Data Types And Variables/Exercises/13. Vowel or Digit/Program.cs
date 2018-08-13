using System;

namespace _13._Vowel_or_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbol = char.Parse(Console.ReadLine());

            if (symbol == 'a' || symbol == 'e' || symbol == 'i' || symbol == 'o' || symbol == 'u' || symbol == 'y')
            {
                Console.WriteLine("vowel");
            }
            else if ((int)symbol >= 48 && (int)symbol <= 57)
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
