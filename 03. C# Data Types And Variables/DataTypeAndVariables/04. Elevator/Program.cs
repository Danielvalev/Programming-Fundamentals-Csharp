using System;

namespace _04._Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int personNumber = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int cources = (int)Math.Ceiling((double)personNumber / capacity);

            Console.WriteLine(cources);

        }
    }
}
