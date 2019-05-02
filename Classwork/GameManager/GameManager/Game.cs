using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GameManager
{
    /// <summary>Represents a game.</summary>
    public class Game : IValidatableObject
    {
        /// <summary>Gets or sets the unique ID of the game.</summary>
        public int Id { get; set; }

        /// <summary>Gets or sets the name of the game.</summary>
        [Required(AllowEmptyStrings = false)]
        public string Name
        {
            //Expression bodied members
            //get { return _name ?? ""; }
            get => _name ?? "";
            //set { _name = value ?? ""; }
            set => _name = value ?? "";
        }

        /// <summary>Gets or sets the description.</summary>        
        //[Required]
        //[Description("Hello")]
        //[Required, Description("Hello")]
        public string Description
        {
            get => _description ?? "";
            set => _description = value;
        }

        /*public bool IsCoolGame
        {
            get { return Price < 59.99M; }
        }*/
        public bool IsCoolGame => Price < 59.99M;

        //private bool IsCoolGame2 = true;

        /// <summary>Gets or sets the price.</summary>
        [RangeAttribute(0, Double.MaxValue, ErrorMessage = "Price must be >= 0.")]
        public decimal Price { get; set; }        

        /// <summary>Determines if the game is owned.</summary>
        public bool Owned { get; set; } = true;

        /// <summary>Determines if the game is completed.</summary>
        public bool Completed { get; set; }

        /// <summary>Converts the object to a string.</summary>
        /// <returns>The string equivalent.</returns>
        //public override string ToString()
        //{
        //    return Name;
        //}        
        public override string ToString() => Name;
        
        //Not needed anymore but leaving in becase ObjectValidator uses it
        public IEnumerable<ValidationResult> Validate( ValidationContext validationContext )
        {
            var items = new List<ValidationResult>();

            ////Name is required
            //if (String.IsNullOrEmpty(Name))
            //    items.Add(new ValidationResult("Name is required.", new[] { nameof(Name) }));

            //Price >= 0
            //if (Price < 0)
            //    items.Add(new ValidationResult("Price must be >= 0.", new[] { nameof(Price) }));

            return items;
        }

        #region Private Members

        private string _name = "";
        private string _description = "";

        #endregion

        #region Demo Code Only

        #region Constructors

        //Default, no return type
        // 1) Cannot be called directly
        // 2) Errors are very bad
        // 3) Should behave no different than doing it manually        
        public Game()
        {
            //Complex init
            var x = 1 + 2;
        }

        //Constructor chaining
        public Game( string name ) : this(name, 0)
        {
            //Name = name;
        }

        //As soon as you define a ctor, no default ctor anymore
        public Game( string name, decimal price )// : this()
        {
            Name = name;
            Price = price;
        }
        #endregion

        //Calculated property
        /*public bool IsCoolGame
        {
            get { return Publisher != "EA"; }
        }*/

        //Mixed accessibility
        //public double Rate { get; internal set; }

        //public void Foo()
        //{
        //    //NOT DETERMINISTIC - should have been a method
        //    var now = DateTime.Now;
        //}


        //Setter only
        //public string Password
        //{
        //    set { }
        //}

        //Auto property equivalent
        //public decimal Price
        //{
        //    get { return _price; }
        //    set { _price = value; }
        //}
        //private decimal _price;

        //Can init the data as well
        //public string[] Genres { get; set; }

        // Don't use array properties because they require cloning
        // and are inefficient
        //public string[] Genres
        //{
        //    get 
        //    {
        //        var temp = new string[_genres.Length];
        //        Array.Copy(_genres, temp, _genres.Length);
        //        return temp;
        //    }
        //}
        //private string[] _genres;

        //public string[] genres = new string[10];
        //private decimal realPrice = Price;
        #endregion
    }
}
