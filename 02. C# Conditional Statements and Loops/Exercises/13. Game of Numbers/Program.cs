using System;

namespace _13._Game_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int magic = int.Parse(Console.ReadLine());

            int count = 0;
            string result = "";
            bool isFound = false;
            for (int i = first; i <= second; i++)
            {
                for (int j = first; j <= second; j++)
                {
                    count++;
                    if ((i + j) == magic)
                    {
                        isFound = true;
                        result = $"{i} + {j}";
                    }
                }
            }
            if (isFound)
            {
                Console.WriteLine($"Number found! {result} = {magic}");
            }
            else
            {
                Console.WriteLine($"{count} combinations - neither equals {magic}");
            }
        }
    }
}
