using System;
using System.Linq;
using System.Numerics;
using System.Text;

namespace _01._Convert_from_base_10_to_base_N
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputTokens = Console.ReadLine().Split();

            int @base = int.Parse(inputTokens[0]);

            BigInteger number = BigInteger.Parse(inputTokens[1]);

            StringBuilder converted = new StringBuilder();

            while (number > 0)
            {
                BigInteger remainder = number % @base;
                converted.Append(remainder);

                number /= @base;
            }

            //for (int i = converted.Length - 1; i >= 0; i--)
            //{
            //    Console.Write($"{converted[i]}");
            //}

            string reversed = string.Concat(converted.ToString().Reverse());

            Console.WriteLine(reversed);


        }
    }
}
