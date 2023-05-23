namespace StocksProgram
{
    public class Program
    {
            static void Main(string[] args)
            {
                Stock s = new Stock();

                bool exit = false;
                while (!exit)
                {
                    Console.WriteLine("1. Add Stock");
                    Console.WriteLine("2. Transactions");
                    Console.WriteLine("3. Portfolio");
                    Console.WriteLine("4. Exit");
                    Console.Write("Enter your choice: ");
                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            s.AddStock();
                            break;
                        case "2":
                            s.ShowTransactions();
                            break;
                        case "3":
                            s.ViewPortfolio();
                            break;
                        case "4":
                            exit = true;
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