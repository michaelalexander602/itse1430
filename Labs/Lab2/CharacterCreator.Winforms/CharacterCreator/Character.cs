/*
 * Michael Alexander
 * ITSE 1430-21722
 * 3-16-19
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    public class Character
    {
        public Character()
        {
            // sets default stats
            Strength = 50;
            Intelligence = 50;
            Agility = 50;
            Constitution = 50;
            Charisma = 50;
        }

        /// <summary>Gets or sets the unique ID of the character.</summary>
        public int Id { get; set; }

        /// <summary>Gets or sets the name of the character.</summary>
        public string Name
        {
            get { return _name ?? ""; }
            set { _name = value ?? ""; }
        }
        private string _name = "";

        /// <summary>Gets or sets the race.</summary>
        public string Race
        {
            get { return _race ?? ""; }
            set { _race = value ?? ""; }
        }
        private string _race = "";

        /// <summary>Gets or sets the profession.</summary>
        public string Profession
        {
            get { return _profession ?? ""; }
            set { _profession = value ?? ""; }
        }
        private string _profession = "";

        /// <summary>Gets or sets strength.</summary>
        public int Strength { get; set; }

        /// <summary>Gets or sets intelligence.</summary>
        public int Intelligence { get; set; }

        /// <summary>Gets or sets agility.</summary>
        public int Agility { get; set; }

        /// <summary>Gets or sets constitution.</summary>
        public int Constitution { get; set; }

        /// <summary>Gets or sets charisma.</summary>
        public int Charisma { get; set; }

        /// <summary>Gets or sets the description.</summary>
        public string Description
        {
            get { return _description ?? ""; }
            set { _description = value ?? ""; }
        }
        private string _description = "";
    }
}
