using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello and welcome! What would you like to order?\n\n" +
                "Enter 1 to order Coffee for 2 euros\n" +
                "Enter 2 to order Cocoa for 3 euros\n" +
                "Enter 3 to order Sandvich for 4 euros\n" +
                "Enter 4 to order Pizza for 5 euros\n");

            int input = Convert.ToInt32(Console.ReadLine());

            if (input == 1)
            {
                Console.WriteLine("\nYou ordered Coffee and you paid 2 euros for it.");
            }

            if (input == 2)
            {
                Console.WriteLine("\nYou ordered Cocoa and you paid 3 euros for it.");
            }

            if (input == 3)
            {
                Console.WriteLine("\nYou ordered Sandvich and you paid 4 euros for it.");
            }

            if (input == 4)
            {
                Console.WriteLine("\nYou ordered Pizza and you paid 5 euros for it.");
            }
        }
    }
}
