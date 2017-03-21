using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Burger myFood_x = new Hamburger(4);
            Burger myFood_y = new Cheeseburger(1);

            Console.WriteLine();

            myFood_x.PrintPrice();
            myFood_y.PrintPrice();

            Console.WriteLine();

            myFood_x.ConfigBurger();

            Console.WriteLine();

            myFood_y.ConfigBurger();
        }
    }
}
