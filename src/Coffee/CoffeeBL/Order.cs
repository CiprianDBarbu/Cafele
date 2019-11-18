using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeBL
{
    public class Order
    {
        public Order()
        {
            coffees = new List<Ordered_Coffee>();
        }
        public Buyer customer { get; set; }
        public List<Ordered_Coffee> coffees { get; set; } 

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
