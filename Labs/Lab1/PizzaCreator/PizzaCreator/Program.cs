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
            Pizza pizza = new Pizza();
            int choice;
            bool orderMade = false;

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

                if(choice == 1)
                {
                    if (orderMade == false)
                    {
                        pizza = NewOrder();
                        orderMade = true;
                    }
                    else
                    {
                        Console.WriteLine("An order has already been made. Do you want to start over?");
                        Console.Write("Enter 'Y' for yes or 'N' for no: ");
                        string input = Console.ReadLine();

                        if(input == "Y" || input == "y")
                        {
                            pizza = NewOrder();
                            orderMade = true;
                        }
                    }

                }
                else if(choice == 2)
                {
                    if(orderMade == true)
                    {
                        ModifyOrder(pizza);
                    }
                    else
                    {
                        Console.WriteLine("An order has not been made.");
                    }
                }
                else if(choice == 3)
                {
                    if(orderMade == true)
                    {
                        ViewOrder(pizza);
                    }
                    else
                    {
                        Console.WriteLine("An order has not been made.");
                    }
                }

            } while (choice != 4);
        }

        static Pizza NewOrder()
        {
            Pizza pizza = new Pizza();
            int choice;

            // set pizza size
            {
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
            }

            // add/remove meats
            {
                Console.WriteLine("Add/Remove the meats of your choice for " + pizza.MeatPrice + " each:");
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
            }

            // add/remove veggies
            {
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
            }

            // pick sauce
            {
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
            }

            // set cheese amount
            {
                Console.WriteLine("Choose the amount of cheese you want: ");
                Console.WriteLine("1. Regular (FREE)");
                Console.WriteLine("2. Extra (+ $1.00)");
                Console.Write("Enter a number (1-2): ");

                while ((!int.TryParse(Console.ReadLine(), out choice)) || choice < 1 || choice > 2)
                {
                    Console.Write("Not a valid option. Enter 1-2: ");
                }
                pizza.AddCheese(choice);
            }

            // pick delivery method
            {
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

            return pizza;
        }

        static Pizza ModifyOrder(Pizza pizza)
        {
            int choice;

            // change size
            {
                Console.WriteLine("Pick the size of your pizza:");
                Console.Write("1. Small ($5.00)");
                if (pizza.Size == "Small")
                {
                    Console.Write(" (selected)");
                }

                Console.Write("\n2. Medium ($6.25)");
                if (pizza.Size == "Medium")
                {
                    Console.Write(" (selected)");
                }

                Console.Write("\n3. Large ($8.75)");
                if (pizza.Size == "Large")
                {
                    Console.Write(" (selected)");
                }
                Console.Write("\nEnter a number (1-3): ");

                while ((!int.TryParse(Console.ReadLine(), out choice)) || choice < 1 || choice > 3)
                {
                    Console.Write("Not a valid option. Enter 1-3: ");
                }
                pizza.SetSize(choice);
            }

            // change meats
            {
                Console.WriteLine("Add/Remove the meats of your choice for " + pizza.MeatPrice + " each:");
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
            }

            // change veggies
            {
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
            }

            // change sauce
            {
                Console.WriteLine("Select the sauce of your choice: ");
                Console.Write("1. Traditional (FREE)");
                if (pizza.Sauce == "Traditional Sauce")
                {
                    Console.Write(" (selected)");
                }
                Console.Write("\n2. Garlic (+ $1.00)");
                if (pizza.Sauce == "Garlic Sauce")
                {
                    Console.Write(" (selected)");
                }
                Console.Write("\n3. Oregano (+ $1.00)");
                if (pizza.Sauce == "Oregano Sauce")
                {
                    Console.Write(" (selected)");
                }
                Console.Write("Enter a number (1-3): ");

                while ((!int.TryParse(Console.ReadLine(), out choice)) || choice < 1 || choice > 3)
                {
                    Console.Write("Not a valid option. Enter 1-3: ");
                }
                pizza.AddSauce(choice);
            }

            // change cheese amount
            {
                Console.WriteLine("Choose the amount of cheese you want: ");
                Console.Write("1. Regular (FREE)");
                if(pizza.HasExtraCheese == false)
                {
                    Console.Write(" (selected)");
                }
                Console.WriteLine("\n2. Extra (+ $1.00)");
                if (pizza.HasExtraCheese == false)
                {
                    Console.Write(" (selected)");
                }
                Console.Write("\nEnter a number (1-2): ");

                while ((!int.TryParse(Console.ReadLine(), out choice)) || choice < 1 || choice > 2)
                {
                    Console.Write("Not a valid option. Enter 1-2: ");
                }
                pizza.AddCheese(choice);
            }

            // change delivery method
            {
                Console.WriteLine("Choose your desired delivery method ");
                Console.Write("1. Pick up (FREE)");
                if (pizza.IsDelivery == false)
                {
                    Console.Write(" (selected)");
                }
                Console.Write("\n2. Delivery (+ $1.00)");
                if (pizza.IsDelivery == true)
                {
                    Console.Write("(selected)");
                }
                Console.Write("\nEnter a number (1-2): ");

                while ((!int.TryParse(Console.ReadLine(), out choice)) || choice < 1 || choice > 2)
                {
                    Console.Write("Not a valid option. Enter 1-2: ");
                }
                pizza.PickDelivery(choice);
            }

            return pizza;
        }

        static void ViewOrder(Pizza pizza)
        {
            // display size
            if(pizza.Size == "Small")
            {
                Console.WriteLine(pizza.Size + " Pizza: $5.00");
            }
            else if(pizza.Size == "Medium")
            {
                Console.WriteLine(pizza.Size + " Pizza: $6.25");
            }
            else if (pizza.Size == "Large")
            {
                Console.WriteLine(pizza.Size + " Pizza: $8.75");
            }

            // display delivery method
            if (pizza.IsDelivery)
            {
                Console.WriteLine("Delivery: $2.50");
            }
            else
            {
                Console.WriteLine("Take Out: FREE");
            }

            // display meats
            Console.WriteLine("Meats:");
            if(pizza.HasBacon || pizza.HasHam || pizza.HasPepperoni || pizza.HasSausage)
            {
                if (pizza.HasBacon)
                {
                    Console.WriteLine("\tBacon: $0.75");
                }
                if (pizza.HasHam)
                {
                    Console.WriteLine("\tHam: $0.75");
                }
                if (pizza.HasPepperoni)
                {
                    Console.WriteLine("\tPepperoni: $0.75");
                }
                if (pizza.HasSausage)
                {
                    Console.WriteLine("\tPepperoni: $0.75");
                }
            }
            else
            {
                Console.WriteLine("(None)");
            }

            // display veggies
            Console.WriteLine("Veggies:");
            if (pizza.HasBOlives || pizza.HasMushrooms || pizza.HasOnions || pizza.HasPeppers)
            {
                if (pizza.HasBOlives)
                {
                    Console.WriteLine("\tBlack Olives: $0.50");
                }
                if (pizza.HasMushrooms)
                {
                    Console.WriteLine("\tMushrooms: $0.50");
                }
                if (pizza.HasOnions)
                {
                    Console.WriteLine("\tOnions: $0.50");
                }
                if (pizza.HasPeppers)
                {
                    Console.WriteLine("\tPeppers: $0.50");
                }
            }
            else
            {
                Console.WriteLine("(None)");
            }

            // display sauce
            if(pizza.Sauce == "Traditional Sauce")
            {
                Console.WriteLine(pizza.Sauce + ": FREE");
            }
            else if(pizza.Sauce == "Garlic Sauce" || pizza.Sauce == "Oregano Sauce")
            {
                Console.WriteLine(pizza.Sauce + ": $1.00");
            }

            // display total
            Console.WriteLine("-----------------------");
            Console.WriteLine("Total: {0:C}", pizza.CalcPrice());
        }
    }
}
