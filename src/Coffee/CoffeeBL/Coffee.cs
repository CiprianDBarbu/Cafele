using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeBL
{
    public enum eflavour_coffee
    {
        none = 0,
        sour = 1,
        strong = 2,
        mild = 3
    }
    public class Coffee : Product
    {
       
        public string origin_country { get; set; }
        public eflavour_coffee flavour { get; set; }
        

        
        public override string ToString()
        {
            return "Coffee :" + base.ToString() + " , " + base.price;
        }


    }
}
