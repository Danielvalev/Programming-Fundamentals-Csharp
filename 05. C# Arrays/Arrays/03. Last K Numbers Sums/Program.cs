﻿using System;

namespace _03._Last_K_Numbers_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            long[] numbers = new long[n];
            numbers[0] = 1;

            SumLastKNumbers(numbers, k);
            Console.Write(string.Join(" ", numbers));
        }

        private static void SumLastKNumbers(long[] numbers, int k)
        {

            for (int currentElement = 0; currentElement < numbers.Length; currentElement++)
            {
                int startIndex = Math.Max(0, currentElement - k);
                int endIntex = currentElement;
                long sum = 0;

                for (int i = startIndex; i <= endIntex; i++)
                {
                    sum += numbers[i];
                }

                numbers[currentElement] = sum;
            }
        }
    }
}
