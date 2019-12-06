using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeBL
{
    public enum eflavour_syroup
    {
        none = 0,
        sweet = 1,
        salty = 2
    }
    public class Syroup : Product
    {
       
        public eflavour_syroup flavour { get; set; }
        public override string ToString()
        {
            return base.ToString() + " " + price;
        }
    }
}
