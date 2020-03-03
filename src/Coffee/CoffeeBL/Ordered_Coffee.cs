using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeBL
{
    public enum coffee_type
    {
        None=0,
        mill = 1,
        brewed = 2
    }
    public class Ordered_Coffee
    {
        public Ordered_Coffee()
        {
            this.quantity = 1;
            this.coffee = new Coffee();
            this.syroup = new Syroup();
        }
        public Coffee coffee { get; set; }
        public Syroup syroup { get; set; }
        public coffee_type type { get; set; }

        public int quantity { get; set; }
        public float actual_price {
            get
            {
                return quantity * coffee.price + syroup.price;
            }
        
        }

        

    }
}
