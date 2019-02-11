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
        public double SmallPrice = 5.00;
        public double MedPrice = 6.25;
        public double LargePrice = 8.75;
        public double MeatPrice = 0.75;
        public double VegPrice = 0.50;
        public double SaucePrice = 1.00;
        public double ExtraCheesePrice = 1.25;
        public double DeliveryPrice = 2.50;
        public double Price;
        public string Size = "";
        public string Sauce;
        public bool HasBacon;
        public bool HasHam;
        public bool HasPepperoni;
        public bool HasSausage;
        public bool HasBOlives;
        public bool HasMushrooms;
        public bool HasOnions;
        public bool HasPeppers;
        public bool HasExtraCheese;
        public bool IsDelivery;

        public void SetSize(int choice)
        {
            if (choice == 1)
            {
                Size = "Small";
            }
            else if (choice == 2)
            {
                Size = "Medium";
            }
            else if (choice == 3)
            {
                Size = "Large";
            }
            else
            {
                Console.WriteLine("Error");
            }
        }

        public void AddMeats(int choice)
        {
            // Bacon
            if (choice == 1)
            {
                if (HasBacon == false)
                {
                    Console.WriteLine("Bacon added.");
                    HasBacon = true;
                }
                else
                {
                    Console.WriteLine("Bacon removed.");
                    HasBacon = false;
                }
            }

            // Ham
            if (choice == 2)
            {
                if (HasHam == false)
                {
                    Console.WriteLine("Ham added.");
                    HasHam = true;
                }
                else
                {
                    Console.WriteLine("Ham removed.");
                    HasHam = false;
                }
            }

            // Pepperoni
            if (choice == 3)
            {
                if (HasPepperoni == false)
                {
                    Console.WriteLine("Pepperoni added.");
                    HasPepperoni = true;
                }
                else
                {
                    Console.WriteLine("Pepperoni removed.");
                    HasPepperoni = false;
                }
            }

            // Sausage
            if (choice == 4)
            {
                if (HasSausage == false)
                {
                    Console.WriteLine("Sausage added.");
                    HasSausage = true;
                }
                else
                {
                    Console.WriteLine("Sausage removed.");
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
                    HasBOlives = true;
                }
                else
                {
                    Console.WriteLine("Black Olives removed.");
                    HasBOlives = false;
                }
            }

            // Mushrooms
            if (choice == 2)
            {
                if (HasMushrooms == false)
                {
                    Console.WriteLine("Mushrooms added.");
                    HasMushrooms = true;
                }
                else
                {
                    Console.WriteLine("Mushrooms removed.");
                    HasMushrooms = false;
                }
            }

            // Onions
            if (choice == 3)
            {
                if (HasOnions == false)
                {
                    Console.WriteLine("Onions added.");
                    HasOnions = true;
                }
                else
                {
                    Console.WriteLine("Onions removed.");
                    HasOnions = false;
                }
            }

            // Peppers
            if (choice == 4)
            {
                if (HasPeppers == false)
                {
                    Console.WriteLine("Peppers added.");
                    HasPeppers = true;
                }
                else
                {
                    Console.WriteLine("Peppers removed.");
                    HasPeppers = false;
                }
            }
        }

        public void AddSauce(int choice)
        {
            if (choice == 1)
            {
                Sauce = "Traditional Sauce";
            }

            if (choice == 2)
            {
                Sauce = "Garlic Sauce";
            }

            if (choice == 3)
            {
                Sauce = "Oregano Sauce";
            }
        }

        public void AddCheese(int choice)
        {
            if (choice == 1)
            {
                HasExtraCheese = false;
            }
            if (choice == 2)
            {
                HasExtraCheese = true;
            }
        }

        public void PickDelivery(int choice)
        {
            if (choice == 1)
            {
                IsDelivery = false;
            }
            else
            {
                IsDelivery = true;
            }
        }

        public double CalcPrice()
        {
            Price = 0.0;
            if(Size == "Small")
            {
                Price += SmallPrice;
            }
            else if (Size == "Medium")
            {
                Price += MedPrice;
            }
            else if (Size == "Large")
            {
                Price += LargePrice;
            }
 
            // add meat prices
            if(HasBacon == true)
            {
                Price += MeatPrice;
            }
            if (HasHam == true)
            {
                Price += MeatPrice;
            }
            if (HasPepperoni == true)
            {
                Price += MeatPrice;
            }
            if (HasSausage == true)
            {
                Price += MeatPrice;
            }

            // add veggie prices
            if (HasBOlives == true)
            {
                Price += VegPrice;
            }
            if (HasMushrooms == true)
            {
                Price += VegPrice;
            }
            if (HasOnions == true)
            {
                Price += VegPrice;
            }
            if (HasPeppers == true)
            {
                Price += VegPrice;
            }

            // sauce price
            if (Sauce == "Garlic Sauce" || Sauce == "Oregano Sauce")
            {
                Price += SaucePrice;
            }

            if (HasExtraCheese == true)
            {
                Price += ExtraCheesePrice;
            }

            if (IsDelivery == true)
            {
                Price += DeliveryPrice;
            }

            return Price;
        }
    }
}
