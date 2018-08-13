using System;

namespace _06._Interval_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            int numMax = Math.Max(num1, num2);
            int numMin = Math.Min(num1, num2);

            for (int i = numMin; i <= numMax; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
