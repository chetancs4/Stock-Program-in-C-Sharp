using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockProgram
{
    public class Stock
    {
        static Dictionary<string, decimal> stockPrices = new Dictionary<string, decimal>();
        public void AddStockPrice()
        {
            Console.Write("Enter stock symbol: ");
            string symbol = Console.ReadLine();

            Console.Write("Enter stock price: ");
            string priceStr = Console.ReadLine();

            if (!decimal.TryParse(priceStr, out decimal price))
            {
                Console.WriteLine("Invalid price. Please enter a valid decimal number.");
                return;
            }

            stockPrices[symbol] = price;
            Console.WriteLine("Stock added successfully.");
        }

        public void UpdateStockPrice()
        {
            Console.Write("Enter stock symbol: ");
            string symbol = Console.ReadLine();

            if (!stockPrices.ContainsKey(symbol))
            {
                Console.WriteLine("Stock symbol not found.");
                return;
            }

            Console.Write("Enter new stock: ");
            string priceStr = Console.ReadLine();

            if (!decimal.TryParse(priceStr, out decimal price))
            {
                Console.WriteLine("Invalid price. Please enter a valid decimal number.");
                return;
            }

            stockPrices[symbol] = price;
            Console.WriteLine("Stock price updated successfully.");
        }

        public void DeleteStockPrice()
        {
            Console.Write("Enter stock symbol: ");
            string symbol = Console.ReadLine();

            if (!stockPrices.ContainsKey(symbol))
            {
                Console.WriteLine("Stock symbol not found.");
                return;
            }

            stockPrices.Remove(symbol);
            Console.WriteLine("Stock deleted successfully.");
        }

        public void ViewStockPrices()
        {
            Console.WriteLine("Stocks Portfolio:- ");

            if (stockPrices.Count == 0)
            {
                Console.WriteLine("No stock available.");
                return;
            }

            foreach (var kvp in stockPrices)
            {
                Console.WriteLine($"{kvp.Key} : {kvp.Value}");
            }
        }
    }
}

