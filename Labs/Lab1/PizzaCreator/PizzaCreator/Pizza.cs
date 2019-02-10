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
    class Pizza
    {
        double Price;
        string Size;
        string Sauce;
        bool HasBacon;
        bool HasHam;
        bool HasPepperoni;
        bool HasSausage;
        bool HasBOlives;
        bool HasMushrooms;
        bool HasOnions;
        bool HasPeppers;
        bool HasExtraCheese;
        bool IsDelivery;

        public void SetSize(int choice)
        {
            if(choice == 1)
            {
                Size = "Small";
                Price += 5.00;
            }
            else if(choice == 2)
            {
                Size = "Medium";
                Price += 6.25;
            }
            else if (choice == 3)
            {
                Size = "Large";
                Price += 8.75;
            }
            else
            {
                Console.WriteLine("Error");
            }
        }

        public void AddMeats(int choice)
        {
            // Bacon
            if(choice == 1)
            {
                if(HasBacon == false)
                {
                    Console.WriteLine("Bacon added.");
                    Price += 0.75;
                    HasBacon = true;
                }
                else
                {
                    Console.WriteLine("Bacon removed.");
                    Price -= 0.75;
                    HasBacon = false;
                }
            }

            // Ham
            if (choice == 2)
            {
                if (HasHam == false)
                {
                    Console.WriteLine("Ham added.");
                    Price += 0.75;
                    HasHam = true;
                }
                else
                {
                    Console.WriteLine("Ham removed.");
                    Price -= 0.75;
                    HasHam = false;
                }
            }

            // Pepperoni
            if (choice == 3)
            {
                if (HasPepperoni == false)
                {
                    Console.WriteLine("Pepperoni added.");
                    Price += 0.75;
                    HasPepperoni = true;
                }
                else
                {
                    Console.WriteLine("Pepperoni removed.");
                    Price -= 0.75;
                    HasPepperoni = false;
                }
            }

            // Sausage
            if (choice == 4)
            {
                if (HasSausage == false)
                {
                    Console.WriteLine("Sausage added.");
                    Price += 0.75;
                    HasSausage = true;
                }
                else
                {
                    Console.WriteLine("Sausage removed.");
                    Price -= 0.75;
                    HasSausage = false;
                }
            }
        }

        public void AddVeggies(int choice)
        {
            // Black olives
            if (choice == 1)
            {
                if (HasBOlives == false)
                {
                    Console.WriteLine("Black Olives added.");
                    Price += 0.50;
                    HasBOlives = true;
                }
                else
                {
                    Console.WriteLine("Black Olives removed.");
                    Price -= 0.50;
                    HasBOlives = false;
                }
            }

            // Mushrooms
            if (choice == 2)
            {
                if (HasMushrooms == false)
                {
                    Console.WriteLine("Mushrooms added.");
                    Price += 0.50;
                    HasMushrooms = true;
                }
                else
                {
                    Console.WriteLine("Mushrooms removed.");
                    Price -= 0.50;
                    HasMushrooms = false;
                }
            }

            // Onions
            if (choice == 3)
            {
                if (HasOnions == false)
                {
                    Console.WriteLine("Onions added.");
                    Price += 0.50;
                    HasOnions = true;
                }
                else
                {
                    Console.WriteLine("Onions removed.");
                    Price -= 0.50;
                    HasOnions = false;
                }
            }

            // Peppers
            if (choice == 4)
            {
                if (HasPeppers == false)
                {
                    Console.WriteLine("Peppers added.");
                    Price += 0.50;
                    HasPeppers = true;
                }
                else
                {
                    Console.WriteLine("Peppers removed.");
                    Price -= 0.50;
                    HasPeppers = false;
                }
            }
        }

        public void AddSauce(int choice)
        {
            if(choice == 1)
            {
                Sauce = "Traditional Sauce";
            }

            if (choice == 2)
            {
                Sauce = "Garlic Sauce";
                Price += 1.00;
            }

            if (choice == 3)
            {
                Sauce = "Oregano Sauce";
                Price += 1.00;
            }
        }

        public void AddCheese(int choice)
        {
            if(choice == 1)
            {
                HasExtraCheese = false;
            }
            if (choice == 2)
            {
                HasExtraCheese = true;
                Price += 1.25;
            }
        }

        public void PickDelivery(int choice)
        {
            if(choice == 1)
            {
                IsDelivery = false;
            }
            else
            {
                IsDelivery = true;
                Price += 2.50;
            }
        }
    }
}
