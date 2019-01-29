using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main( string[] args )
        {
            NewGame();
            DisplayGame();
        }

        private static void CSharpBasics()
        {
            string name;

            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine();

            Console.Write("Hello " + name);
            Console.WriteLine(name);
        }

        private static void NewGame()
        {
            Console.WriteLine("Enter the name: ");
            name = Console.ReadLine();

            //Console.WriteLine("Do you own this: ");
            //string owned = Console.ReadLine();
            owned = ReadBoolean("Owned (Y/N)?");

            //Console.WriteLine("Enter the price: ");
            //string price = Console.ReadLine();
            price = ReadDecimal("Price?");

            Console.WriteLine("Publisher? ");
            publisher = Console.ReadLine();

            //Console.WriteLine("Completed? ");
            //string completed = Console.ReadLine();
            completed = ReadBoolean("Completed (Y/N)?");
        }

        private static void DisplayGame()
        {
            // var = type inference: compiler determines the appropriate type dempending on the use
            var literal1 = "Hello \"Bob\"";
            var path = "C:\\Windows\\System32";
            path += "\\Temp";
            var path2 = @"C:\Windows\System32";

            // 1. string concat
            Console.WriteLine("Name: " + name);

            // 2. string format
            string str = String.Format("Price: {0:C}", price);
            Console.WriteLine(str);

            // 3. function overload - just calls String.Format
            Console.WriteLine("Publisher: {0}", publisher);

            // 4. Concatenation
            str = String.Concat("Owned?", " ", owned);
            Console.WriteLine(str);

            // 5. Interpolation
            Console.WriteLine($"Completed? {completed}");

            // convert to string
            string strPrice = price.ToString("C");

            // is string empty?
            string input = null;
            int length = input.Length;
            bool isEmpty;

            // 1.
            //if (input != null)
            //    isEmpty = input.Length == 0;
            //else
            //    isEmpty = true;

            // 2.
            isEmpty = (input != null) ? input.Length == 0 : true;

            // 3.
            isEmpty = input == "";

            // 4.
            isEmpty = input == String.Empty;

            // 5.
            isEmpty = String.IsNullOrEmpty(input);

            // Comparison
            bool areEqual = "Hello" == "hello";
            areEqual = String.Compare("Hello", "hello", true) == 0;

            // conversion
            input = input.ToUpper();
            input = input.ToLower();

            // manipulation
            bool startsWith = input.StartsWith("http:");
            bool endWith = input.EndsWith("/");

            input = input.TrimStart();  // removes whitespace from front
            input = input.TrimEnd();    // removes whitespace from back
            input = input.Trim();       // removes whitespace from front and back

            input = input.PadLeft(10);  // add whitespace up to 10 characters
            input = input.PadRight(10); 
        }

        private static bool ReadBoolean(string message)
        {
            do
            {
                Console.WriteLine(message);
                string result = Console.ReadLine().ToUpper();

                //Validate it is a boolean
                if (result == "Y")
                    return true;
                if (result == "N")
                    return false;

                /*switch (result)
                {
                    case "Y":
                    case "y":
                    return true;

                    case "N":
                    case "n":
                    return false;

                    default:
                    Console.WriteLine("Enter Y or N");
                    break;
                };*/

                Console.WriteLine("Enter Y or N");
            } while (true);

            
        }

        private static decimal ReadDecimal(string message)
        {
            while (true)
            {
                Console.WriteLine(message);
                string value = Console.ReadLine();

                //decimal result;
                if (Decimal.TryParse(value, out decimal result))
                    return result;

                Console.WriteLine("Enter a valid decimal value");
            };
        }

        private static string name;
        private static string publisher;
        private static decimal price;
        private static bool owned;
        private static bool completed;
    }
}
