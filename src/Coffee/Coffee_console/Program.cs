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
            Console.WriteLine($"Welcome {B.name}");

            
            

        }
    }
}
