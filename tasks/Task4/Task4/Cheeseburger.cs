using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Cheeseburger : Burger
    {
        public double price => 1.3;
        public int amount => 0;
        public int addedIngridientsInt => 0;
        public string[] addedIngridientsStr => null;

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
            int i = 0;

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
                    addedIngridientsStr[i] = "Salad";
                    addedIngridientsInt++;
                    i++;
                }
                else
                {
                    Console.WriteLine("No salad.");
                }

                Console.Write("\nOnions? (Enter) ");
                if (Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    standardPrice = standardPrice + 0.2;
                    addedIngridientsStr[i] = "Onions";
                    addedIngridientsInt++;
                    i++;
                }
                else
                {
                    Console.WriteLine("No onions.");
                }

                Console.Write("\nTomatos? (Enter) ");
                if (Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    standardPrice = standardPrice + 0.2;
                    addedIngridientsStr[i] = "Tomatos";
                    addedIngridientsInt++;
                    i++;
                }
                else
                {
                    Console.WriteLine("No tomatos.");
                }

                Console.Write("\nChilis? (Enter) ");
                if (Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    standardPrice = standardPrice + 0.2;
                    addedIngridientsStr[i] = "Chilis";
                    addedIngridientsInt++;
                    i++;
                }
                else
                {
                    Console.WriteLine("No chillis.");
                }

                Console.WriteLine($"\nNew price: {standardPrice * (double)userAmount} euros");
            }
        }

        public void PrintAmount()
        {
            if (addedIngridientsInt != 0)
            {
                Console.WriteLine($"You added {addedIngridientsInt} ingridients.");
            }
            else
            {
                Console.WriteLine("No ingridients have been added.");
            }
        }

        public void PrintIngridients()
        {
            if (addedIngridientsStr != null)
            {
                int i = 0;

                Console.Write("You added: ");
                for (i = addedIngridientsStr.Length; i < addedIngridientsStr.Length; i++)
                {
                    Console.Write($"{addedIngridientsStr[i]}, ");
                }
            }
            else
            {
                Console.WriteLine("No ingridients have been added.");
            }
        }
    }
}
