using System;

namespace _10._Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int count = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine($"{num1} X {count} = {num1 * count}");
                count++;
            } while (count <= 10);
        }
    }
}
