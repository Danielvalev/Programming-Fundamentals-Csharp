using System;
using System.Text;

namespace _06._Sum_big_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string num1 = Console.ReadLine();
            string num2 = Console.ReadLine();

            int maxLength = Math.Max(num1.Length, num2.Length);
            num1 = num1.PadLeft(maxLength, '0');
            num2 = num2.PadLeft(maxLength, '0');

            int remainder = 0;

            StringBuilder result = new StringBuilder();

            for (int i = maxLength - 1; i >= 0; i--)
            {
                int firstDigits = int.Parse(num1[i].ToString());
                int secondDigits = int.Parse(num2[i].ToString());

                int currentSum = firstDigits + secondDigits + remainder;
                remainder = 0;

                if (currentSum > 9)
                {
                    currentSum -= 10;
                    remainder++;

                }
                result.Append(currentSum);
            }

            result.Append(remainder);
            string output = result.ToString().TrimEnd('0');

            for (int i = output.Length - 1; i >= 0; i--)
            {
                Console.Write(output[i]);
            }


        }
    }
}
