using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Cheeseburger : Burger
    {
        public double Price => 1.3;
        public int amount = 0;

        public Cheeseburger(int amount)
        {
            Amount = amount;

            Console.WriteLine($"Your amount: {amount}");
        }

        public int Amount
        {
            get
            {
                return amount;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Value lower than 0 is invalid", nameof(amount));
                }
                else
                {
                    amount = value;
                }
            }
        }

        public void PrintPrice()
        {
            Console.WriteLine($"Price of cheeseburger: {Price} euros");
        }

        public void ConfigBurger()
        {
            string userInput;
            int userAmount = amount;
            double standardPrice = Price;

            Console.WriteLine("Your cheeseburger contains a patty, cheese, pickels and ketchup.");
            Console.Write("Do you want to add something? Yes/No ");
            userInput = Console.ReadLine();

            if (userInput != "Yes")
            {
                if (userInput != "No")
                {
                    Console.WriteLine("Invalid input.");
                }
                else
                {
                    Console.WriteLine($"No extras. Price: {standardPrice * (double)userAmount} euros");
                }
            }
            else
            {
                Console.Write("Salad? (Enter) ");
                if (Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    standardPrice = standardPrice + 0.2;
                }

                Console.Write("\nOnions? (Enter) ");
                if (Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    standardPrice = standardPrice + 0.2;
                }

                Console.Write("\nTomatos? (Enter) ");
                if (Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    standardPrice = standardPrice + 0.2;
                }

                Console.Write("\nChilis? (Enter) ");
                if (Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    standardPrice = standardPrice + 0.2;
                }
                Console.WriteLine($"\nNew price: {standardPrice * (double)userAmount} euros");
            }
        }
    }
}
