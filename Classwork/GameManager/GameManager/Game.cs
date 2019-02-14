using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManager
{
    /// <summary>Represents a game.</summary>
     public class Game
    {
        /// <summary>Name of the game.</summary>
        public string Name
        {
            get { return _name ?? ""; }
            set { _name = value ?? ""; }
        }

        private string _name = "";

        /// <summary>Publisher of the game.</summary>
        public string Publisher
        {
            get { return _publisher ?? ""; }
            set { _publisher = value; }
        }
        private string _publisher = "";

        // calculated property
        public bool IsCoolGame
        {
            get { return Publisher != "EA"; }
        }

        // auto property
        public decimal Price { get; set; }

        //public decimal Price
        //{
        //    get { return _price; }
        //    set { _price = value; }
        //}
        //private decimal _price;

        public bool Owned { get; set; } = true;     //initializes to true by default

        public bool Completed { get; set; }

        // mixed accessibility
        public double Rate
        {
            get;
            internal set;
        }

        //Can init the data as well
        //public string[] genres = new string[10];
        //private decimal realPrice = Price;

        /// <summary>Validates the object.</summary>
        /// <returns>true if valid or false otherwise.</returns>
        public bool Validate( /* Game this */ )
        {
            //Redundant dude
            //var str = this.Name;

            //Name is required
            if (String.IsNullOrEmpty(Name))
                return false;

            //Price >= 0
            if (Price < 0)
                return false;

            //Only if you need to pass the instance to somebody else
            //MyType.Foo(this);

            return true;
        }
    }
}
