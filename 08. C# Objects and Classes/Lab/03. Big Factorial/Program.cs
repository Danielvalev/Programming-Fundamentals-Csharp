﻿using System;
using System.Numerics;

namespace _03._Big_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger fac = 1;

            for (int i = 1; i <= n; i++)
            {
                fac *= i;
            }

            Console.WriteLine(fac);
        }
    }
}