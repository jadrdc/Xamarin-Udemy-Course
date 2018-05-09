using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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
    public partial class ActivityFeedMaster : ContentPage
    {
        /// public ListView ListView;
        private IActivitySearchService Service;

        public ListView GetListView { get { return this.MenuItemsListView; } }
        public ActivityFeedMaster()
        {
            InitializeComponent();

            Service = new MockUserActivityService();
            this.MenuItemsListView.ItemsSource = Service.GetActivities();
          
        }
        

    }
}