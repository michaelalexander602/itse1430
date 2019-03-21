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
            Strength = 50;
            Intelligence = 50;
            Agility = 50;
            Constitution = 50;
            Charisma = 50;
        }

        public int Id { get; set; }

        public string Name
        {
            get { return _name ?? ""; }
            set { _name = value ?? ""; }
        }
        private string _name = "";

        public string Race
        {
            get { return _race ?? ""; }
            set { _race = value ?? ""; }
        }
        private string _race = "";

        public string Profession
        {
            get { return _profession ?? ""; }
            set { _profession = value ?? ""; }
        }
        private string _profession = "";

        public int Strength { get; set; }

        public int Intelligence { get; set; }

        public int Agility { get; set; }

        public int Constitution { get; set; }

        public int Charisma { get; set; }

        public string Description
        {
            get { return _description ?? ""; }
            set { _description = value ?? ""; }
        }
        private string _description = "";
    }
}
