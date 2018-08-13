using System;

namespace _04._Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nightsCount = int.Parse(Console.ReadLine());

            double studioPrice = 0;
            double doublePrice = 0;
            double suitePrice = 0;

            if (month == "May" || month == "October")
            {
                studioPrice += 50;
                doublePrice += 65;
                suitePrice += 75;
            }
            else if (month == "June" || month == "September")
            {
                studioPrice += 60;
                doublePrice += 72;
                suitePrice += 82;
            }
            else if (month == "July" || month == "August" || month == "December")
            {
                studioPrice += 68;
                doublePrice += 77;
                suitePrice += 89;
            }

            if ((month == "September" || month == "October") && nightsCount > 7)
            {
                nightsCount -= 1;
            } else if ((month == "June" || month == "September") && nightsCount > 14)
            {
                doublePrice = doublePrice * 0.9;
            } else if ((month == "July" || month == "August" || month == "December") && nightsCount > 14)
            {
                suitePrice = suitePrice * 0.85;
            }
            else if ((month == "May" || month == "October") && nightsCount > 7)
            {
                studioPrice = studioPrice * 0.95;
            }

            double studioTotalPrice = studioPrice * nightsCount;
            double doubleTotalPrice = doublePrice * nightsCount;
            double suiteTotalPrice = suitePrice * nightsCount;

            Console.WriteLine($"Studio: {studioTotalPrice:F2} lv.");
            Console.WriteLine($"Double: {doubleTotalPrice:F2} lv.");
            Console.WriteLine($"Suite: {suiteTotalPrice:F2} lv.");

        }

    }
}
