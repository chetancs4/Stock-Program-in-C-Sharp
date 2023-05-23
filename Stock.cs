using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace StocksProgram
{
    public class Stock
    {
        public Stock() { }

        private static List<Stock> portfolio = new List<Stock>();
        private static List<Transaction> transactions = new List<Transaction>();
        public string Symbol { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public Stock(string symbol, string name, decimal price, int quantity)
        {
            Symbol = symbol;
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public override string ToString()
        {
            return $"Symbol: {Symbol}\nName: {Name}\nPrice: {Price:C}\nQuantity: {Quantity}\n";
        }
        public void AddStock()
        {
            Console.WriteLine("Enter stock information:");
            Console.Write("Symbol: ");
            string symbol = Console.ReadLine();
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Price: ");
            decimal price = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Quantity: ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            Stock stock = new Stock(symbol, name, price, quantity);
            portfolio.Add(stock);

            Transaction transaction = new Transaction(DateTime.Now, $"Added stock: {stock.Symbol} - Quantity: {stock.Quantity}");
            transactions.Add(transaction);

            Console.WriteLine("Stock added successfully!");
        }

        public void ShowTransactions()
        {
            Console.WriteLine("Transaction History:");
            foreach (Transaction transaction in transactions)
            {
                Console.WriteLine(transaction.ToString());
            }
        }

        public void ViewPortfolio()
        {
            if (portfolio.Count > 0)
            {
                Console.WriteLine("Portfolio: ");
                foreach (Stock stock in portfolio)
                {
                    Console.WriteLine(stock.ToString());
                }
            }
            else
            {
                Console.WriteLine("Portfolio is empty.");
            }
        }
    }
    public class Transaction
    {
        public DateTime DateTime { get; set; }
        public string Description { get; set; }

        public Transaction(DateTime dateTime, string description)
        {
            DateTime = dateTime;
            Description = description;
        }

        public override string ToString()
        {
            return $"{DateTime} - {Description}";
        }
    }
}
