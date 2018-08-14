﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Count_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            int[] arr = new int[1001];

            foreach (int num in numbers)
            {
                arr[num]++;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    Console.WriteLine("{0} -> {1}", i, arr[i]);
                }
            }
        }
    }
}
