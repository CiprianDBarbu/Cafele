using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeBL
{
    public enum order_state
    {
        adding = 0,
        user_finished = 1,
        in_preparation = 2,
        finished = 3,
        delivered =4
    }

    public class Order
    {
        public Order()
        {
            coffees = new List<Ordered_Coffee>();
            customer = new Buyer();
            this.state = order_state.adding;
        }
        public Buyer customer { get; set; }
        public List<Ordered_Coffee> coffees { get; set; } 
        public order_state state { get; set; }

        public float total_price 
        { 
            get
            {
                float price = 0; 
                for(int i= 0; i < coffees.Count; i++)
                {
                    price += coffees[i].actual_price;
                }
                return price;
            }
        }
    }
}
