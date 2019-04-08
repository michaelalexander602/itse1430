using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager.Business
{
    public interface IContactDatabase
    {
        Contact Add(Contact contact);
        Contact Get(int id);
        IEnumerable<Contact> GetAll();
        void Remove(int id);
        Contact Update(int id, Contact contact);
    }
}
