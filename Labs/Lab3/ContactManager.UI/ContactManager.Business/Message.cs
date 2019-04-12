using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager.Business
{
    public class Message
    {
        public Contact Contact { get; set; }

        public string Subject
        {
            get { return _subject ?? ""; }
            set { _subject = value ?? ""; }
        }
        private string _subject = "";

        public string Body
        {
            get { return _body ?? ""; }
            set { _body = value ?? ""; }
        }
        private string _body = "";

        public override string ToString()
        {
            return "To: " + Contact.Name + " - " + Contact.Email + " | Subject: "
                    + Subject + " | Body: " + Body;
        }
    }
}
