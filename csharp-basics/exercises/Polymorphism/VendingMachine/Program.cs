using System;

namespace VendingMachine
{
    internal class Program
    {
        private static decimal currentAmount = 0m;
        private static decimal price = 0m;
        private static int quantity = 0;
        private static bool quit = false;

        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-IE");
            Console.OutputEncoding = System.Text.Encoding.Default;

            DisplayWelcomeMessage();
            DisplayProducts();
            ProcessInput();
            DisplayExitMessage();
        }

        private static void DisplayWelcomeMessage()
        {
            Console.WriteLine("Welcome to Axls Vending Machine");
        }

        private static void DisplayProducts()
        {
            Console.WriteLine("Products available:");
            Console.WriteLine("1. Pepsi Cola - €1.50 - 5 left");
            Console.WriteLine("2. Twister Chips - €1.00 - 3 left");
            Console.WriteLine("3. Skittles Candy - €0.75 - 10 left");
        }

        private static void ProcessInput()
        {
            while (!quit)
            {
                Console.WriteLine("Insert coin (10, 20, 50, 100, 200 cents) or 'q' to quit:");
                string input = Console.ReadLine();

                if (input == "q")
                {
                    quit = true;
                }
                else
                {
                    AddCoin(input);
                }

                if (!quit)
                {
                    Console.WriteLine("Enter product number or 'q' to quit:");
                    input = Console.ReadLine();

                    if (input == "q")
                    {
                        quit = true;
                    }
                    else
                    {
                        DispenseProduct(input);
                    }
                }
            }
            DisplayChangeReturned();
        }
        private static void AddCoin(string input)
        {
            int coin = int.Parse(input);
            if (coin == 10 || coin == 20 || coin == 50 || coin == 100 || coin == 200)
            {
                currentAmount += coin / 100m;
                Console.WriteLine($"Current amount: {currentAmount:C}");
                while (currentAmount < price)
                {
                    Console.WriteLine("Insert additional coin (10, 20, 50, 100, 200 cents) or 'q' to quit:");
                    input = Console.ReadLine();

                    if (input == "q")
                    {
                        quit = true;
                        break;
                    }
                    else
                    {
                        coin = int.Parse(input);

                        if (coin == 10 || coin == 20 || coin == 50 || coin == 100 || coin == 200)
                        {
                            currentAmount += coin / 100m;
                            Console.WriteLine($"Current amount: {currentAmount:C}");
                        }
                        else
                        {
                            Console.WriteLine("Invalid coin. Try again.");
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid coin. Try again.");
            }
        }

        private static void DispenseProduct(string input)
        {
            int productOption = int.Parse(input);
            string productName = "";
            switch (productOption)
            {
                case 1:
                    price = 1.5m;
                    quantity = 5;
                    productName = "Pepsi Cola";
                    break;
                case 2:
                    price = 1.0m;
                    quantity = 3;
                    productName = "Twister Chips";
                    break;
                case 3:
                    price = 0.75m;
                    quantity = 10;
                    productName = "Skittles Candy";
                    break;
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
            if (price > currentAmount)
            {
                Console.WriteLine("Not enough money. Try again.");
            }
            else if (quantity <= 0)
            {
                Console.WriteLine("Out of stock.");

            }
            else
            {
                Console.WriteLine($"Dispensing {productName}.");
                quantity--;
                currentAmount -= price;
            }
        }

        private static void DisplayChangeReturned()
        {
            if (currentAmount > 0)
            {
                Console.WriteLine($"Returning change: {currentAmount:C}");
            }
            else
            {
                Console.WriteLine("No change to return.");
            }
        }

        private static void DisplayExitMessage()
        {
            Console.WriteLine("Thank you for using Axls Vending Machine.");
        }
    }
}