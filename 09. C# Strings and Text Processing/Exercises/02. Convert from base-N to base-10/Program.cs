using System;
using System.Linq;
using System.Numerics;
using System.Text;

namespace _02._Convert_from_base_N_to_base_10
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split();

            int @base = int.Parse(tokens[0]);

            string numAsString = tokens[1];

            int pow = 0;

            BigInteger sum = 0;

            for (int i = numAsString.Length - 1; i >= 0; i--)
            {
                char currentChar = numAsString[i];
                int currentNumber = int.Parse(currentChar.ToString());

                BigInteger currentSum = currentNumber * BigInteger.Pow(@base, pow);
                sum += currentSum;
                pow++;
            }

            Console.WriteLine(sum);


        }
    }
}
