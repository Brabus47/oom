using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            McDonalds myOrder = new McDonalds(true, "Cash");
            myOrder.CashOrCard = "Card";

            Console.WriteLine($"Want an order? {myOrder.Order}, Your payment: {myOrder.CashOrCard}");
            Console.WriteLine($"Burger :{myOrder.PriceBurger}, Pommes: {myOrder.PricePommes}, Drink: { myOrder.PriceDrink}");

            myOrder.GetPrice("Burger");
        }
    }
}
