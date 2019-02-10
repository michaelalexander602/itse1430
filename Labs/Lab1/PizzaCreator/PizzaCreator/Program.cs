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

                while ((!int.TryParse(Console.ReadLine(), out choice)) || choice < 1 || choice > 4)
                {
                    Console.Write("Not a valid option. Enter 1-4: ");
                }

                //while (choice < 1 || choice > 4)
               // {
                    //.WriteLine("Invalid Selection! Please enter a number (1-4)");
                    //int.TryParse(Console.ReadLine(), out choice);
                //}

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
            Pizza pizza = new Pizza();
            int choice;

            // set pizza size
            Console.WriteLine("Pick the size of your pizza:");
            Console.WriteLine("1. Small ($5.00)");
            Console.WriteLine("2. Medium ($6.25)");
            Console.WriteLine("3. Large ($8.75)");
            Console.Write("Enter a number (1-3): ");

            while ((!int.TryParse(Console.ReadLine(), out choice)) || choice < 1 || choice > 3)
            {
                Console.Write("Not a valid option. Enter 1-3: ");
            }
            pizza.SetSize(choice);

            // add/remove meats
            Console.WriteLine("Add/Remove the meats of your choice for $0.75 each:");
            Console.WriteLine("1. Bacon");
            Console.WriteLine("2. Ham");
            Console.WriteLine("3. Pepperoni");
            Console.WriteLine("4. Sausage");
            Console.WriteLine("5. NEXT");
            do
            {
                Console.Write("Enter a number (1-5): ");

                while ((!int.TryParse(Console.ReadLine(), out choice)) || choice < 1 || choice > 5)
                {
                    Console.Write("Not a valid option. Enter 1-5: ");
                }
                pizza.AddMeats(choice);

            } while (choice != 5);

            // add/remove veggies
            Console.WriteLine("Add/Remove the veggies of your choice for $0.75 each:");
            Console.WriteLine("1. Black olives");
            Console.WriteLine("2. Mushrooms");
            Console.WriteLine("3. Onions");
            Console.WriteLine("4. Peppers");
            Console.WriteLine("5. NEXT");
            do
            {
                Console.Write("Enter a number (1-5): ");

                while ((!int.TryParse(Console.ReadLine(), out choice)) || choice < 1 || choice > 5)
                {
                    Console.Write("Not a valid option. Enter 1-4: ");
                }
                pizza.AddVeggies(choice);

            } while (choice != 5);

            // pick sauce
            Console.WriteLine("Select the sauce of your choice: ");
            Console.WriteLine("1. Traditional (FREE)");
            Console.WriteLine("2. Garlic (+ $1.00)");
            Console.WriteLine("3. Oregano (+ $1.00)");
            Console.Write("Enter a number (1-3): ");

            while ((!int.TryParse(Console.ReadLine(), out choice)) || choice < 1 || choice > 3)
            {
                Console.Write("Not a valid option. Enter 1-3: ");
            }
            pizza.AddSauce(choice);

            // set cheese amount
            Console.WriteLine("Choose the amount of cheese you want: ");
            Console.WriteLine("1. Regular (FREE)");
            Console.WriteLine("2. Extra (+ $1.00)");
            Console.Write("Enter a number (1-2): ");

            while ((!int.TryParse(Console.ReadLine(), out choice)) || choice < 1 || choice > 2)
            {
                Console.Write("Not a valid option. Enter 1-2: ");
            }
            pizza.AddCheese(choice);

            // pick delivery method
            Console.WriteLine("Choose your desired delivery method ");
            Console.WriteLine("1. Pick up (FREE)");
            Console.WriteLine("2. Delivery (+ $1.00)");
            Console.Write("Enter a number (1-2): ");

            while ((!int.TryParse(Console.ReadLine(), out choice)) || choice < 1 || choice > 2)
            {
                Console.Write("Not a valid option. Enter 1-2: ");
            }
            pizza.PickDelivery(choice);
        }

        static void ModifyOrder()
        {

        }

        static void ViewOrder()
        {

        }
    }
}
