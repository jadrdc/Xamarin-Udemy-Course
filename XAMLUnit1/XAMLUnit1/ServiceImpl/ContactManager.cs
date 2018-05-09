using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XAMLUnit1.Models;
using XAMLUnit1.Services;

namespace XAMLUnit1.ServiceImpl
{
   public class ContactManager : IContactDAO
    {
        ObservableCollection<Contact> ContactList;

        public ContactManager()
        {
            ContactList = new ObservableCollection<Contact>()
            { new Contact()
            {
                 Blocked=true, Email="Issoto@simetricaconsultin.com", LastName="Soto", Name="Isaias", Telephone="809-222-6666"
            }, new Contact()
            {
                 Blocked=false, Email="jtaveras@simetricaconsultin.com", LastName="Taveras", Name="Johan", Telephone="849-222-6666"
            }
            };
           
        }
        public bool Add(Contact contact)
        {
            ContactList.Add(contact);

            return true;        }

        public bool Delete(Contact contact)
        {
          return  ContactList.Remove(contact);
        }

        public bool Get(int Id)
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<Contact> GetContacts()
        {
            return ContactList;
        }

        public bool Update(Contact contact)
        {
            throw new NotImplementedException();
        }
    }
}
