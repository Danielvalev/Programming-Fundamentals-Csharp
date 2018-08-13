using System;

namespace _09._Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            int count = 1;

            while(count <= 10)
            {
                Console.WriteLine($"{number} X {count} = {number * count}");
                count++;
            }

        }
    }
}
