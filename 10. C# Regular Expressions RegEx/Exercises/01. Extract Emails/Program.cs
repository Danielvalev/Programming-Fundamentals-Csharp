using System;
using System.Text.RegularExpressions;

namespace _01._Extract_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<=\s)[A-Za-z0-9]+([.\-_]?[A-Za-z0-9]+)*@[A-Za-z]+(\-[A-Za-z]+)*(\.[A-Za-z]+)+";

            Regex regex = new Regex(pattern);

            string text = Console.ReadLine();

            MatchCollection matches = regex.Matches(text);

            foreach (Match match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}
