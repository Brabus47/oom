using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    interface Burger
    {
        double Price { get; }

        void PrintPrice();
        void ConfigBurger();
    }
}
