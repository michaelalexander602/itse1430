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
        public string Name = "";

        /// <summary>Publisher of the game</summary>
        public string Publisher = "";
        public decimal Price;
        public bool Owned;
        public bool Completed;
        
        /// <summary>/// Validates the object/// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            //Name is required
            if (String.IsNullOrEmpty(Name))
                return false;

            // price >=0
            if (Price < 0)
            {
                return false;
            }

            return true;
        }
    }
}
