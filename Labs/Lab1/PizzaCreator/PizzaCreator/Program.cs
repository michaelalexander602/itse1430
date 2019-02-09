/*
 * Michael Alexander
 * ITSE 1430-21722
 * 2-11-19
 */ 


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("1. New Order");
                Console.WriteLine("2. Modify Order");
                Console.WriteLine("3. Display Order");
                Console.WriteLine("4. Quit");
                Console.Write("Make your selection by entering a number (1-4): ");

                while (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Error");
                }

                //choice = int.Parse(Console.ReadLine());
                Console.Write(choice);

                while (choice < 1 || choice > 4)
                {
                    Console.WriteLine("Invalid Selection! Please enter a number (1-4)");
                    int.TryParse(Console.ReadLine(), out choice);
                }

                switch (choice)
                {
                    case 1:
                        NewOrder();
                        break;
                    case 2:
                        ModifyOrder();
                        break;
                    case 3:
                        ViewOrder();
                        break;
                }

            } while (choice != 4);
        }

        static void NewOrder()
        {
            
        }

        static void ModifyOrder()
        {

        }

        static void ViewOrder()
        {

        }
    }
}
