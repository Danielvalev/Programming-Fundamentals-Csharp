﻿using System;

namespace _01._Passed
{
    class Program
    {
        static void Main(string[] args)
        {
            var grade = double.Parse(Console.ReadLine());
            if (grade >= 3.00)
            {
                Console.WriteLine("Passed!");
            } else if (grade < 3.00)
            {
                Console.WriteLine("Failed!");
            }
        }
    }
}
