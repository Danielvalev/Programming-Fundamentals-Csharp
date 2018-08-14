using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Search_for_a_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read a List
            List<int> inputList = Console.ReadLine().Split().Select(int.Parse).ToList();

            // Read a Array
            int[] command = Console.ReadLine().Split().Select(int.Parse).ToArray();

            // Create new list of int
            List<int> manipulatedList = new List<int>();

            // Take a first num from 
            int takeNums = command[0];

            // Delete a nummber
            int deleteNums = command[1];

            // Search for number
            int searchNum = command[2];


            // Add a numbers in the new list - take only take numbers
            for (int i = 0; i < takeNums; i++)
            {
                manipulatedList.Add(inputList[i]);

            }

            // Delete nums from manipulatedList
            for (int i = 0; i < deleteNums; i++)
            {
                manipulatedList.RemoveAt(0);
            }

            // Search if manipulatedList have / or dont have a searchNum
            if (manipulatedList.Contains(searchNum))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }




        }
    }
}
