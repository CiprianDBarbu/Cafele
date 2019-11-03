using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeBL
{
    class Order
    {
        public Buyer customer { get; set; }
        public Ordered_Coffee coffees { get; set; } /*voiam * cu ideea de a fi un pointer pe care se poate aloca dinamic vectorul de cafele*/
    }
}
