using System;
using System.Text.RegularExpressions;

namespace _04._Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            var command = Console.ReadLine();
            var email = "";

            while (command != "stop")
            {
                email = Console.ReadLine();

                var pattern = new Regex(@"[A-Za-z]+\@[A-Za-z]+\.(?!(uk|us)).*");

                var matches = pattern.Matches(email);

                foreach (Match username in matches)
                {
                    Console.WriteLine($"{command} -> {username.Value.Trim()}");
                    break;
                }
                command = Console.ReadLine();
            }
        }
    }
}
