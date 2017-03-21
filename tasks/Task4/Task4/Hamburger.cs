using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Hamburger : Burger
    {
        public double Price => 1.0;
        public int amount = 0;

        public Hamburger(int amount)
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
            Console.WriteLine($"Price of hamburger: {Price} euros");
        }

        public void ConfigBurger()
        {
            string userInput;
            int userAmount = amount;
            double standardPrice = Price;

            Console.WriteLine("Your hamburger contains a patty, pickels and ketchup.");
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
                else
                {
                    Console.WriteLine("No salad.");
                }

                Console.Write("\nOnions? (Enter) ");
                if (Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    standardPrice = standardPrice + 0.2;
                }
                else
                {
                    Console.WriteLine("No onions.");
                }

                Console.Write("\nTomatos? (Enter) ");
                if (Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    standardPrice = standardPrice + 0.2;
                }
                else
                {
                    Console.WriteLine("No tomatos.");
                }

                Console.Write("\nChilis? (Enter) ");
                if (Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    standardPrice = standardPrice + 0.2;
                }
                else
                {
                    Console.WriteLine("No chillis.");
                }

                Console.WriteLine($"\nNew price: {standardPrice * (double)userAmount} euros");
            }
        }
    }
}
