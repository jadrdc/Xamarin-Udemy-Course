using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XAMLUnit1.Models;

namespace XAMLUnit1.Services
{
    public interface IContactDAO
    {
        Boolean Add(Contact contact);
        Boolean Delete(Contact contact);
        Boolean Update(Contact contact);
        Boolean Get(int Id);
        ObservableCollection<Contact> GetContacts();


    }
}
