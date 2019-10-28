using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeBL
{
    enum eflavour_coffee
    {
        none = 0,
        sour = 1,
        strong = 2,
        mild = 3
    }
    class Coffee : Product
    {
       
        public string orgin_country { get; set; }
        public eflavour_coffee flavour { get; set; }
        
        
    }
}
