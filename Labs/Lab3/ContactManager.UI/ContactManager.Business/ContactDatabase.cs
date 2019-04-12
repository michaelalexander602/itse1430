using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager.Business
{
    public class ContactDatabase : IContactDatabase
    {
        private readonly List<Contact> _items = new List<Contact>();
        private int _nextId = 0;

        /// <summary>adds a contact to the database.</summary>
        public Contact Add(Contact contact)
        {
            if (contact == null)
                throw new ArgumentNullException(nameof(contact));

            //contact names must be unique
            var existing = FindByName(contact.Name);
            if (existing != null)
                throw new Exception("Contact must be unique.");

            contact.Id = ++_nextId;
            _items.Add(Clone(contact));

            return contact;
        }

        /// <summary>gets a specified contact by its id.</summary>
        public Contact Get(int id)
        {
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id), "Id must be > 0.");

            var index = GetIndex(id);
            if (index >= 0)
                return Clone(_items[index]);

            return null;
        }

        public IEnumerable<Contact> GetAll()
        {
            return _items.Select(Clone);
        }

        /// <summary>removes a specified contact by its id.</summary>
        public void Remove(int id)
        {
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id), "Id must be > 0.");

            var index = GetIndex(id);
            if (index >= 0)
                _items.RemoveAt(index);
        }

        /// <summary>replaces an existing contact</summary>
        public Contact Update(int id, Contact contact)
        {
            //Validate
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id), "Id must be > 0.");
            if (contact == null)
                throw new ArgumentNullException(nameof(contact));

            var existing = Get(id);
            if (existing == null)
                throw new Exception("Contact does not exist.");

            //Game names must be unique            
            var sameName = FindByName(contact.Name);
            if (sameName != null && sameName.Id != id)
                throw new Exception("Contact must be unique.");

            var index = GetIndex(id);

            contact.Id = id;
            existing = _items[index];
            Clone(existing, contact);

            return contact;
        }

        protected virtual Contact FindByName(string name)
        {
            return (from contact in GetAll()
                    where String.Compare(contact.Name, name, true) == 0
                    select contact).FirstOrDefault();
        }

        private Contact Clone(Contact contact)
        {
            var newContact = new Contact();
            Clone(newContact, contact);

            return newContact;
        }

        private void Clone(Contact target, Contact source)
        {
            target.Id = source.Id;
            target.Name = source.Name;
            target.Email = source.Email;
        }

        private int GetIndex(int id)
        {
            var game = _items.Where(g => g.Id == id).FirstOrDefault(); 
            if (game != null)
                return _items.IndexOf(game);
            return -1;
        }
    }
}
