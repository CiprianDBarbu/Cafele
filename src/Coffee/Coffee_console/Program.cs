using CoffeeBL;
using Menu;
using System;

namespace Coffee_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Order d= new Order();
            Console.WriteLine("Please enter your name!");
            string name = Console.ReadLine();

            Buyer B = new Buyer();
            B.name = name;
            if (B.IsValid() != validation_result.succes)
            {
                Console.WriteLine("Invalid name!");
                //todo: what to do?
                return;
            }
            d.customer = B;
            Console.WriteLine($"Welcome {B.name}");

            CoffeeMenu cm = new CoffeeMenu();
            cm.loadfromfile();
          
            cm.ShowCoffeeInOrder();

            Console.WriteLine(" now choose coffee");
           



            bool orderdone = false;
            while (!orderdone)
            {
                Ordered_Coffee oc = new Ordered_Coffee();
                Console.WriteLine("Please chose coffee!");
                string namecoffee = Console.ReadLine();


                if (cm.ExistCoffee(namecoffee))
                {
                    Console.WriteLine($"Thank you for chosing {namecoffee}");
                    oc.coffee_order = cm.GiveCoffeeAfterName(namecoffee);
                }
                else
                    Console.WriteLine("Not found coffee!\n");

                Console.WriteLine("Please choose quantity!");
                string quantity_coffee = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(quantity_coffee))
                {
                    oc.quantity = 1;
                }
                else 
                {
                    Console.WriteLine("Thank you for choosing quantity!");
                    int quant_coffee = Int32.Parse(quantity_coffee);
                    oc.quantity = quant_coffee;
                }

                d.coffees.Add(oc);

                //oc.actual_price = oc.quantity * oc.coffee_order.price;
                //d.total_price = d.total_price + oc.actual_price;

                Console.WriteLine("Is the order done?(Y/N)");
                string ok = Console.ReadLine().ToUpper();
                if (ok == "Y" )
                    orderdone = true;
            }

            Console.WriteLine("Your order:\n");
            for(int i = 0; i < d.coffees.Count;i++)
            {
                var curent = d.coffees[i];
                //curent.actual_price = 1;
                Console.WriteLine($"Coffee: {curent.coffee_order.name}  Quantity:{curent.quantity}  Price:{curent.actual_price}\n");
            }
            Console.WriteLine($"Total: {d.total_price}");


        }
    }
}
