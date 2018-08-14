using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a sortDictionary
            var countNumbers = new SortedDictionary<double, int>();

            // Read numbers from console and add it in array
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (!countNumbers.ContainsKey(numbers[i]))
                {
                    countNumbers.Add(numbers[i], 1);
                }
                else
                {
                    countNumbers[numbers[i]]++;
                }
            }

            foreach (var number in countNumbers)
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
        }
    }
}
