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
            int choice = 0;
            do
            {
                Console.WriteLine("1. New Order");
                Console.WriteLine("2. Modify Order");
                Console.WriteLine("3. Display Order");
                Console.WriteLine("4. New Order");
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
            } while (choice != 4);
        }
    }
}
