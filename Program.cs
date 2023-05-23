namespace StockProgram
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            Stock s = new Stock();

            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("Stock Program");
                Console.WriteLine("1. Add stock ");
                Console.WriteLine("2. Update stock");
                Console.WriteLine("3. Delete stock");
                Console.WriteLine("4. View stocks");
                Console.WriteLine("5. Exit");

                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        s.AddStockPrice();
                        break;
                    case "2":
                        s.UpdateStockPrice();
                        break;
                    case "3":
                        s.DeleteStockPrice();
                        break;
                    case "4":
                        s.ViewStockPrices();
                        break;
                    case "5":
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
                Console.WriteLine();
            }
        }
    }
}
