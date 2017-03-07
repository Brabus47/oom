using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._1
{
    class McDonalds
    {
        private bool order = false;
        private string cashOrCard = "";
        private double priceOfBurger = 3.40;
        private double priceOfPommes = 1.80;
        private double priceOfDrink = 2.10;

        public McDonalds(bool orderTaking, string payment)
        {
            if (orderTaking == false)
            {
                Console.WriteLine("No order no food. Come next time (:");
            }
            else
            {
                if (orderTaking != true)
                {
                    throw new Exception("Input is invalid (no boolean)");
                }

                if (string.IsNullOrWhiteSpace(payment))
                {
                    throw new Exception("No string was entered.");
                }

                if (payment != "Card")
                {
                    if (payment != "Cash")
                    {
                        throw new Exception("Payment has to be 'Cash' or 'Card'.");
                    }
                    else
                    {
                        TakeOrder(priceOfBurger, priceOfPommes, priceOfDrink, cashOrCard);
                    }
                }
            }
        }

        public double PriceBurger { get { return priceOfBurger; } }
        public double PricePommes { get { return priceOfPommes; } }
        public double PriceDrink { get { return priceOfDrink; } }

        public bool Order
        {
            get { return order; }
            set
            {
                if (value == false)
                {
                    Console.WriteLine("If you don't want to order you can leave :D");
                }
                else
                {
                    if (value != true)
                    {
                        throw new Exception("Input is invalid (no boolean)");
                    }
                    order = value;
                }
            }
        }

        public string CashOrCard
        {
            get { return cashOrCard; }
            set
            {
                if (string.IsNullOrWhiteSpace(cashOrCard))
                {
                    throw new Exception("Method of paying has to be choosen.");
                }

                if (cashOrCard == "Cash")
                {
                    cashOrCard = value;
                }
                else
                {
                    if (cashOrCard == "Card")
                    {
                        cashOrCard = value;
                    }
                    else
                    {
                        throw new Exception("Invalid input.");
                    }
                }
            }
        }

        public double PayTheOrder(string payment, double total)
        {
            string money = "";
            double convertMoney = 0;

            if (payment != "Card")
            {
                if (payment != "Cash")
                {
                    throw new Exception("Input has to be 'Cash' or 'Card'.");
                }
                else
                {
                    Console.Write("Your money: ");
                    money = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(money))
                    {
                        throw new Exception("Empty string.");
                    }

                    convertMoney = Convert.ToDouble(money);

                    if (convertMoney < total)
                    {
                        throw new Exception("Money is less than the total of the order.");
                    }

                    return convertMoney;
                }
            }
            else
            {
                return total;
            }
        }

        public void MenuOrder(double burger, double pommes, double drink, string payment)
        {
            double menuPrice = (burger + pommes + drink);
            double money = 0;

            Console.WriteLine($"The menu contains a burger, pommes and a drink.\nTotal: {menuPrice}");
            Console.WriteLine("Do you wanna pay with cash or card?");
            payment = Console.ReadLine();

            money = PayTheOrder(payment, menuPrice);

            Console.WriteLine($"Your change: {money - menuPrice}");
        }

        public void TakeOrder(double burger, double pommes, double drink, string payment)
        {
            double order = 0;
            double money = 0;
            string takeOrNot = "";
            string menu = "";
            double menuPrice = (burger + pommes + drink);

            Console.WriteLine("Do you want a menu? Yes/No");
            menu = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(menu))
            {
                throw new Exception("Nothing was entered.");
            }

            if (menu != "Yes")
            {
                if (menu != "No")
                {
                    Console.WriteLine("You didn't choose an order.");
                }
                else
                {
                    Console.WriteLine("Do you want a Burger? Yes/No");
                    takeOrNot = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(takeOrNot))
                    {
                        Console.WriteLine("You didn't choose anything.");
                    }

                    if (takeOrNot != "No")
                    {
                        if (takeOrNot != "Yes")
                        {
                            Console.WriteLine("You didn't choose anything.");
                        }
                        else
                        {
                            order = order + burger;
                        }
                    }

                    Console.WriteLine("Do you want Pommes? Yes/No");
                    takeOrNot = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(takeOrNot))
                    {
                        Console.WriteLine("You didn't choose anything.");
                    }

                    if (takeOrNot != "No")
                    {
                        if (takeOrNot != "Yes")
                        {
                            Console.WriteLine("You didn't choose anything.");
                        }
                        else
                        {
                            order = order + pommes;
                        }
                    }

                    Console.WriteLine("Do you want a Drink? Yes/No");
                    takeOrNot = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(takeOrNot))
                    {
                        Console.WriteLine("You didn't choose anything.");
                    }

                    if (takeOrNot != "No")
                    {
                        if (takeOrNot != "Yes")
                        {
                            Console.WriteLine("You didn't choose anything.");
                        }
                        else
                        {
                            order = order + drink;
                        }
                    }

                    if (order <= 0)
                    {
                        Console.WriteLine("Don't fool me, get out of here!");
                    }
                    else
                    {
                        Console.WriteLine($"Total: {order}");
                        Console.WriteLine("How do you want to pay? Cash/Card");
                        payment = Console.ReadLine();

                        money = PayTheOrder(payment, order);

                        Console.WriteLine($"Your change: {money - (burger + pommes + drink)}");
                    }
                }
            }
            else
            {
                MenuOrder(burger, pommes, drink, payment);
            }
        }

        public void GetPrice(string priceRequest)
        {
            if (string.IsNullOrWhiteSpace(priceRequest))
            {
                Console.WriteLine("No input was given.");
            }
            else
            {
                if (priceRequest != "Burger")
                {
                    if (priceRequest != "Pommes")
                    {
                        if (priceRequest != "Drink")
                        {
                            Console.WriteLine("No valid input.");
                        }
                        else
                        {
                            Console.WriteLine($"Price of drink: {priceOfDrink}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Price of pommes: {priceOfPommes}");
                    }
                }
                else
                {
                    Console.WriteLine($"Price of burger: {priceOfBurger}");
                }
            }
        }
    }
}
