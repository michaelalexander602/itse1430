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
                Console.Clear();
                Console.WriteLine("1. New Order");
                Console.WriteLine("2. Modify Order");
                Console.WriteLine("3. Display Order");
                Console.WriteLine("4. Quit");
                Console.WriteLine("\nCurrent total: {0:C}", pizza.CalcPrice());
                Console.Write("\nMake your selection by entering a number (1-4): ");

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
                        Console.Write("\nPress [Enter] to continue. ");
                        Console.ReadLine();
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
                        Console.Write("\nPress [Enter] to continue. ");
                        Console.ReadLine();
                    }
                }

            } while (choice != 4);
        }

        static Pizza NewOrder()
        {
            Pizza pizza = new Pizza();
            int choice;

            // set pizza size
            Console.Clear();
            {
                Console.WriteLine("Pick the size of your pizza:");
                Console.WriteLine("1. Small ({0:C})", pizza.SmallPrice);
                Console.WriteLine("2. Medium ({0:C})", pizza.MedPrice);
                Console.WriteLine("3. Large ({0:C})", pizza.LargePrice);
                Console.Write("Enter a number (1-3): ");

                while ((!int.TryParse(Console.ReadLine(), out choice)) || choice < 1 || choice > 3)
                {
                    Console.Write("Not a valid option. Enter 1-3: ");
                }
                pizza.SetSize(choice);
            }

            // add/remove meats
            Console.Clear();
            {
                Console.WriteLine("Add/Remove the meats of your choice for {0:C} each:", pizza.MeatPrice);
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
            Console.Clear();
            {
                Console.WriteLine("Add/Remove the veggies of your choice for {0:C} each:", pizza.VegPrice);
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
            Console.Clear();
            {
                Console.WriteLine("Select the sauce of your choice: ");
                Console.WriteLine("1. Traditional (FREE)");
                Console.WriteLine("2. Garlic (+ {0:C})", pizza.SaucePrice);
                Console.WriteLine("3. Oregano (+ {0:C})", pizza.SaucePrice);
                Console.Write("Enter a number (1-3): ");

                while ((!int.TryParse(Console.ReadLine(), out choice)) || choice < 1 || choice > 3)
                {
                    Console.Write("Not a valid option. Enter 1-3: ");
                }
                pizza.AddSauce(choice);
            }

            // set cheese amount
            Console.Clear();
            {
                Console.WriteLine("Choose the amount of cheese you want: ");
                Console.WriteLine("1. Regular (FREE)");
                Console.WriteLine("2. Extra (+ {0:C})", pizza.ExtraCheesePrice);
                Console.Write("Enter a number (1-2): ");

                while ((!int.TryParse(Console.ReadLine(), out choice)) || choice < 1 || choice > 2)
                {
                    Console.Write("Not a valid option. Enter 1-2: ");
                }
                pizza.AddCheese(choice);
            }

            // pick delivery method
            Console.Clear();
            {
                Console.WriteLine("Choose your desired delivery method ");
                Console.WriteLine("1. Pick up (FREE)");
                Console.WriteLine("2. Delivery (+ {0:C})", pizza.DeliveryPrice);
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
            Console.Clear();

            // change size
            Console.Clear();
            {
                Console.WriteLine("Pick the size of your pizza:");
                Console.Write("1. Small ({0:C})", pizza.SmallPrice);
                if (pizza.Size == "Small")
                {
                    Console.Write(" (selected)");
                }

                Console.Write("\n2. Medium ({0:C})", pizza.MedPrice);
                if (pizza.Size == "Medium")
                {
                    Console.Write(" (selected)");
                }

                Console.Write("\n3. Large ({0:C})", pizza.LargePrice);
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
            Console.Clear();
            {
                Console.WriteLine("Add/Remove the meats of your choice for {0:C} each:", pizza.MeatPrice);
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
            Console.Clear();
            {
                Console.WriteLine("Add/Remove the veggies of your choice for {0:C} each:", pizza.VegPrice);
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
            Console.Clear();
            {
                Console.WriteLine("Select the sauce of your choice: ");
                Console.Write("1. Traditional (FREE)");
                if (pizza.Sauce == "Traditional Sauce")
                {
                    Console.Write(" (selected)");
                }
                Console.Write("\n2. Garlic (+ {0:C})", pizza.SaucePrice);
                if (pizza.Sauce == "Garlic Sauce")
                {
                    Console.Write(" (selected)");
                }
                Console.Write("\n3. Oregano (+ {0:C})", pizza.SaucePrice);
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
            Console.Clear();
            {
                Console.WriteLine("Choose the amount of cheese you want: ");
                Console.Write("1. Regular (FREE)");
                if(pizza.HasExtraCheese == false)
                {
                    Console.Write(" (selected)");
                }
                Console.Write("\n2. Extra (+ {0:C})", pizza.ExtraCheesePrice);
                if (pizza.HasExtraCheese == true)
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
            Console.Clear();
            {
                Console.WriteLine("Choose your desired delivery method ");
                Console.Write("1. Pick up (FREE)");
                if (pizza.IsDelivery == false)
                {
                    Console.Write(" (selected)");
                }
                Console.Write("\n2. Delivery (+ {0:C})", pizza.DeliveryPrice);
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
            Console.Clear();
            string item;

            // display size
            item = (pizza.Size + " Pizza:").PadRight(20);
            if (pizza.Size == "Small")
            {
                Console.WriteLine(item + "{0:C}", pizza.SmallPrice);
            }
            else if(pizza.Size == "Medium")
            {
                Console.WriteLine(item + "{0:C}", pizza.MedPrice);
            }
            else if (pizza.Size == "Large")
            {
                Console.WriteLine(item + "{0:C}", pizza.LargePrice);
            }

            // display delivery method
            if (pizza.IsDelivery)
            {
                item = ("Delivery:").PadRight(20);
                Console.WriteLine(item + "{0:C}", pizza.DeliveryPrice);
            }
            else
            {
                item = ("Take Out").PadRight(20);
                Console.WriteLine(item + "FREE");
            }

            // display meats
            Console.WriteLine("Meats:");
            if(pizza.HasBacon || pizza.HasHam || pizza.HasPepperoni || pizza.HasSausage)
            {
                if (pizza.HasBacon)
                {
                    item = ("   Bacon:").PadRight(20);
                    Console.WriteLine(item + "{0:C}", pizza.MeatPrice);
                }
                if (pizza.HasHam)
                {
                    item = ("   Ham:").PadRight(20);
                    Console.WriteLine(item + "{0:C}", pizza.MeatPrice);
                }
                if (pizza.HasPepperoni)
                {
                    item = ("   Pepperoni:").PadRight(20);
                    Console.WriteLine(item + "{0:C}", pizza.MeatPrice);
                }
                if (pizza.HasSausage)
                {
                    item = ("   Sausage:").PadRight(20);
                    Console.WriteLine(item + "{0:C}", pizza.MeatPrice);
                }
            }
            else
            {
                Console.WriteLine("   (None)");
            }

            // display veggies
            Console.WriteLine("Veggies:");
            if (pizza.HasBOlives || pizza.HasMushrooms || pizza.HasOnions || pizza.HasPeppers)
            {
                if (pizza.HasBOlives)
                {
                    item = ("   Black Olives:").PadRight(20);
                    Console.WriteLine(item + "{0:C}", pizza.VegPrice);
                }
                if (pizza.HasMushrooms)
                {
                    item = ("   Mushrooms:").PadRight(20);
                    Console.WriteLine(item + "{0:C}", pizza.VegPrice);
                }
                if (pizza.HasOnions)
                {
                    item = ("   Onions:").PadRight(20);
                    Console.WriteLine(item + "{0:C}", pizza.VegPrice);
                }
                if (pizza.HasPeppers)
                {
                    item = ("   Peppers:").PadRight(20);
                    Console.WriteLine(item + "{0:C}", pizza.VegPrice);
                }
            }
            else
            {
                Console.WriteLine("   (None)");
            }

            // display sauce
            item = (pizza.Sauce + ":").PadRight(20);
            if(pizza.Sauce == "Traditional Sauce")
            {
                Console.WriteLine(item + "FREE");
            }
            else if(pizza.Sauce == "Garlic Sauce" || pizza.Sauce == "Oregano Sauce")
            {
                Console.WriteLine(item + "{0:C}", pizza.SaucePrice);
            }

            // display cheese
            if (pizza.HasExtraCheese)
            {
                item = ("Extra Cheese:").PadRight(20);
                Console.WriteLine(item + "{0:C}", pizza.ExtraCheesePrice);
            }
            //else
            //{
            //    Console.WriteLine("Regular Cheese: FREE");
            //}

            // display total
            Console.WriteLine("-------------------------");
            item = ("Total:").PadRight(20);
            Console.WriteLine(item + "{0:C}", pizza.CalcPrice());

            Console.Write("\nPress [Enter] to continue. ");
            Console.ReadLine();
        }
    }
}
