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
    public partial class MainPageContact : ContentPage
    {
        private IContactDAO manager;
        public MainPageContact()
        {
            InitializeComponent();
            manager = new ContactManagerDB();
        }
        protected override void OnAppearing()
        {
            this.ContactsList.ItemsSource = manager.GetContacts();
            base.OnAppearing();
        }
        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ContactInfo(manager));
        }

        private void ContactsList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
           var contact= e.SelectedItem as Contact;
            Navigation.PushAsync(new NavigationPage(new ContactInfo(contact)));
        }

        private  async void MenuItem_Clicked(object sender, EventArgs e)
        {

         var flag=   await  DisplayAlert("Eliminar Contacto","Eliminar Contacto","Si","No");
            
            if (flag == true) { var contact = (sender as MenuItem).CommandParameter as Contact;
                manager.Delete(contact);
            } }
    }
}