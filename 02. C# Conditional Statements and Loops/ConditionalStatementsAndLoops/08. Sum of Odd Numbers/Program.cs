using System;

namespace _08._Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            int sum = 0;
            int oddNumber = 1;
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(oddNumber);
                sum += oddNumber;
                oddNumber += 2;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
