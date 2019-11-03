using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeBL
{
    enum coffee_type
    {
        mill = 0,
        brewed = 1
    }
    class Ordered_Coffee
    {
        public Coffee coffee_order { get; set; }
        public Syroup syroup_order { get; set; }
        public coffee_type type { get; set; }

        public int quantity { get; set; }
    }
}
