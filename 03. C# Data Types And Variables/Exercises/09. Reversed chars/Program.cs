using System;

namespace _09._Reversed_chars
{
    class Program
    {
        static void Main(string[] args)
        {
            char input1 = char.Parse(Console.ReadLine());
            char input2 = char.Parse(Console.ReadLine());
            char input3 = char.Parse(Console.ReadLine());

            string word = "" + input1 + input2 + input3;

            for (int i = word.Length - 1; i >= 0; i--)
            {
                Console.Write(word[i]);
            }
        }
    }
}
