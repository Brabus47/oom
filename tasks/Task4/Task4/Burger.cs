using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    interface Burger
    {
        double price { get; }
        int amount { get; set; }
        int addedIngridientsInt { get; set; }
        string[] addedIngridientsStr { get; }

        void PrintPrice();
        void PrintAmount();
        void PrintIngridients();
        void ConfigBurger();
    }
}
