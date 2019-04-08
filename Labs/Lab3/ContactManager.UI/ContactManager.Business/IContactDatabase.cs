using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager.Business
{
    interface IContactDatabase
    {
        Contact Add(Contact contact);
        Contact Get(string name);
        IEnumerable<Contact> GetAll();
        void Remove(string name);
        Contact Update(Contact contact);
    }
}
