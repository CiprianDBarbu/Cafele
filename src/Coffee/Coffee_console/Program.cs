using CoffeeBL;
using System;

namespace Coffee_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name!");
            string name = Console.ReadLine();

            Buyer B = new Buyer();
            B.name = name;
            if ((B.IsValid() != validation_result.succes) == true)
            {
                Console.WriteLine("Invalid name!");
                return;
            }
            Console.WriteLine($"Welcome {B.name}");

            Console.WriteLine(" now choose coffee");

            
            

        }
    }
}
