using System;
using System.Globalization;

namespace _01._Day_of_Week
{
    class Program
    {
        public static object CultireInfo { get; private set; }

        static void Main(string[] args)
        {
            DateTime input = DateTime.ParseExact(Console.ReadLine(),"d-M-yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(input.DayOfWeek);
        }
    }
}
