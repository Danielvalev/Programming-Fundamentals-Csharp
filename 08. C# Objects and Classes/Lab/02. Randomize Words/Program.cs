﻿using System;

namespace _02._Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            Random rand = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                string currentWord = words[i];

                int randomIndex = rand.Next(0, words.Length-1);
                words[i] = words[randomIndex];
                words[randomIndex] = currentWord;
            }

            Console.WriteLine(string.Join("\n", words));
        }
    }
}
