using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager.Business
{
    public class ContactDatabase : IContactDatabase
    {
        public Contact Add(Contact contact)
        {
            throw new NotImplementedException();
        }

        public Contact Get(string name)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Contact> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(string name)
        {
            throw new NotImplementedException();
        }

        public Contact Update(Contact contact)
        {
            throw new NotImplementedException();
        }

        private readonly List<Contact> _items = new List<Contact>();
    }
}
