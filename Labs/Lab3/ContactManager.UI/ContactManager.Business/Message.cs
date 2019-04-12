using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager.Business
{
    public class Message
    {
        /// <summary>Gets or sets the targeted contact.</summary>
        public Contact Contact { get; set; }

        /// <summary>Gets or sets the subject line of the message.</summary>
        public string Subject
        {
            get { return _subject ?? ""; }
            set { _subject = value ?? ""; }
        }
        private string _subject = "";

        /// <summary>Gets or sets the main body of the message.</summary>
        public string Body
        {
            get { return _body ?? ""; }
            set { _body = value ?? ""; }
        }
        private string _body = "";

        /// <summary>Returns all the message info in a single string.</summary>
        public override string ToString()
        {
            return "To: " + Contact.Name + " - " + Contact.Email + " | Subject: "
                    + Subject + " | Body: " + Body;
        }
    }
}
