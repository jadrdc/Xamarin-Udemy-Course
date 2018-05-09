using HelloWorld;
using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XAMLUnit1.Models;
using XAMLUnit1.Services;

namespace XAMLUnit1.ServiceImpl
{
    public class ContactManagerDB : IContactDAO
    {
        SQLiteAsyncConnection _connection;
        ObservableCollection<Contact> contacts;
        List<Contact> ContactList;


        public  ContactManagerDB()
        {
            ISQLiteDb db = DependencyService.Get<ISQLiteDb>();
            
            _connection = db.GetConnection();
            _connection.CreateTableAsync<Contact>();
             GetContactsListAsync();
        }
        public  bool Add(Contact contact)
        {
           _connection.InsertAsync(contact);
            contacts.Add(contact);
            return true;
        }

        public bool Delete(Contact contact)
        {
            _connection.DeleteAsync(contact);
            contacts.Remove(contact);
            return true;
        }

        public bool Get(int Id)
        {
            throw new NotImplementedException();
        }

        public   ObservableCollection<Contact>  GetContacts()
        {
            if (ContactList!=null )
            {
                contacts = new ObservableCollection<Contact>(ContactList);
            }
            else
            {
                contacts = new ObservableCollection<Contact>();
            }
            
            
            return contacts ;
        }

        public async void  GetContactsListAsync()
        {
            
            ContactList =  await _connection.Table<Contact>().ToListAsync();


        }

        public bool Update(Contact contact)
        {
            _connection.UpdateAsync(contact);
            return true; 
        }
    }
}
