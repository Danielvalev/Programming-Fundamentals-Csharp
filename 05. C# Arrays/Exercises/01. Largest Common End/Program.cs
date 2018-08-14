using System;

namespace _01._Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstInput = Console.ReadLine().Split();
            string[] secondInput = Console.ReadLine().Split();

            int minLength = Math.Min(firstInput.Length, secondInput.Length);

            int countLeft = 0;
            int countRight = 0;

            for (int i = 0; i < minLength; i++)
            {
                if (firstInput[i] == secondInput[i])
                {
                    countLeft++;
                }

                if (firstInput[firstInput.Length - 1 - i] == secondInput[secondInput.Length - 1 - i])
                {
                    countRight++;
                }

            }
            Console.WriteLine(Math.Max(countLeft, countRight));
        }
    }
}
