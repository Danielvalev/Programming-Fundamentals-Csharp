using System;

namespace _03._Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();

            double price = 0;
            double totalPrice = 0;

            if (groupSize <= 50)
            {
                Console.WriteLine("We can offer you the Small Hall");
                price += 2500;
            } else if (groupSize <= 100)
            {
                Console.WriteLine("We can offer you the Terrace");
                price += 5000;
            } else if (groupSize <=120)
            {
                Console.WriteLine("We can offer you the Great Hall");
                price += 7500;
            } else
            {
                Console.WriteLine("We do not have an appropriate hall.");
                return;
            }

            if (package == "Normal")
            {
                price += 500;
                totalPrice = price * 0.95;
            } else if (package == "Gold")
            {
                price += 750;
                totalPrice = price * 0.90;
            } else if (package == "Platinum")
            {
                price += 1000;
                totalPrice = price * 0.85;
            }

            double pricePerPerson = totalPrice / groupSize;
            Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
        }
    }
}
