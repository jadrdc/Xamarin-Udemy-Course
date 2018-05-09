using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XAMLUnit1.Models;
using XAMLUnit1.ServiceImpl;

namespace XAMLUnit1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ActivityFeed : MasterDetailPage
    {
        public ActivityFeed()
        {
            InitializeComponent();
             IsPresented = true;
            var master = (ActivityFeedMaster)Master;
            master.GetListView.ItemSelected += ListView_ItemSelected;
        } 

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

            var activity = e.SelectedItem as Activity;
            var user = new MockupUserSearchService().GetUser(activity.UserId);
            Detail = new NavigationPage(new ActivityFeedDetail(user));
            IsPresented = false;

        }

    }
}