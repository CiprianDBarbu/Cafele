using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeBL
{
   public class Buyer
    {
        public string name { get; set; }

        public validation_result IsValid()
        {
            if (string.IsNullOrWhiteSpace(name)) return validation_result.name_inccorect;
            return validation_result.succes;
        }

        public void CompleteOrder(Order aux)
        {
            aux.OrderStateModify(order_state.user_finished);
        }
    }

  

}
