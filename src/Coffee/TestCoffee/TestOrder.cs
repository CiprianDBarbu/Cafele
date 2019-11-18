using CoffeeBL;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace TestCoffee
{
   
    public class TestOrder
    {
        [Fact]
        public void TestOrderTwoItems()
        {
            Order o = new Order();
            Ordered_Coffee a = new Ordered_Coffee();
            a.quantity = 1;
            a.coffee_order.price = 3;

            Ordered_Coffee b = new Ordered_Coffee();
            b.quantity = 1;
            b.coffee_order.price = 2;

            o.coffees.Add(a);
            o.coffees.Add(b);

            Assert.Equal(5, o.total_price);

        }

        [Fact]
        public void TestActualPrice()
        {
            Ordered_Coffee a = new Ordered_Coffee();
            a.quantity = 4;
            a.coffee_order.price = 3;

            Assert.Equal(12, a.actual_price);
        }
    }
}
