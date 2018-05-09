using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XAMLUnit1.Models;
using XAMLUnit1.ServiceImpl;
using XAMLUnit1.Services;

namespace XAMLUnit1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactInfo : ContentPage
    {
        Contact contact;
        private IContactDAO manager;
        private bool Updated = false;

        public ContactInfo()
        {
            InitializeComponent();
           
            contact = new Contact();
            BindingContext = contact;
        }
        public ContactInfo(Contact contactNew)
        {
            InitializeComponent();
            contact = contactNew;
            BindingContext = contact;
            manager = new ContactManagerDB();
            Updated = true;
        }

        public ContactInfo(IContactDAO manager)
        {
            InitializeComponent();

            contact = new Contact();
            BindingContext = contact;
            this.manager = manager;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {

               if(Updated)
            {
                manager.Update(contact);
            }
            else { 
                     if(
                         String.IsNullOrWhiteSpace(
                         contact.Name) &&
                         String.IsNullOrWhiteSpace(
                         contact.LastName))
                     {
                       await  DisplayAlert("Informacion","Debe de Digitar la informacion del Contacto","OK");
                     }
                     else
                     {
                        manager.Add(contact);
                        await Navigation.PopAsync();
                     }
            }
        }
    
}
}
