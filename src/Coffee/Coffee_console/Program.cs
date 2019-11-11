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

            Console.WriteLine(" now choose coffee");
            CoffeeMenu cm = new CoffeeMenu();
            cm.loadfromfile();
            for (int i = 0; i < cm.CoffeeMenuList.Count; i++)
            {
                var curent = cm.CoffeeMenuList[i];
                Console.WriteLine($"{curent.name}");
            }



            bool orderdone = false;
            while (!orderdone)
            {
                Console.WriteLine("Please chose coffee!");
                string namecoffee = Console.ReadLine();


                if (cm.ExistCoffee(namecoffee))
                {
                    Console.WriteLine($"Thank you for chosing {namecoffee}");
                    Ordered_Coffee oc = new Ordered_Coffee();
                    oc.coffee_order = cm.GiveCoffeeAfterName(namecoffee);

                    d.coffees.Add(oc);

                }
                else
                    Console.WriteLine("Not found coffee!\n");



                Console.WriteLine("Is the order done?(Y/N)");
                string ok = Console.ReadLine().ToUpper();
                if (ok == "Y" )
                    orderdone = true;
            }


        }
    }
}
