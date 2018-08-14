using System;
using System.Collections.Generic;

namespace _07._Sales_Report
{
    class Sale
    {
        public string Town { get; set; }
        public string Product { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }

        public Sale(string Town, string Product, decimal Price, decimal Quantity)
        {
            this.Town = Town;
            this.Product = Product;
            this.Price = Price;
            this.Quantity = Quantity;
        }

        public decimal Multiply()
        {
            return Price * Quantity;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            SortedDictionary<string, decimal> totalSalesByTown = new SortedDictionary<string, decimal>();

            List<Sale> sales = new List<Sale>();
            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split();
                string town = data[0];
                string product = data[1];
                decimal price = decimal.Parse(data[2]);
                decimal quantity = decimal.Parse(data[3]);

                Sale sale = new Sale(town, product, price, quantity);
                sales.Add(sale);
            }
            foreach (var sale in sales)
            {
                if (!totalSalesByTown.ContainsKey(sale.Town))
                {
                    totalSalesByTown.Add(sale.Town, sale.Multiply());
                }
                else
                {
                    totalSalesByTown[sale.Town] += sale.Multiply();
                }
            }

            foreach (var item in totalSalesByTown)
            {
                Console.WriteLine($"{item.Key} -> {item.Value:F2}");
            }
        }
    }
}
