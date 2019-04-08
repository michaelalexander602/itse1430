using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager.Business
{
    public class Contact
    {
        /// <summary>Gets or sets the unique ID of the game.</summary>
        public int Id { get; set; }

        public string Name
        {
            get { return _name ?? ""; }
            set { _name = value ?? ""; }
        }
        private string _name = "";

        public string Email
        {
            get { return _email ?? ""; }
            set { _email = value ?? ""; }
        }
        private string _email = "";

    }
}
