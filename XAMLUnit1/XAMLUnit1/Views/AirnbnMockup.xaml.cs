using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
	public partial class AirnbnMockup : ContentPage
	{
        public ObservableCollection<SearchGroup>SearchGroupList;
        public MockupSearchService Service { get; set; }
		public AirnbnMockup ()
		{
			InitializeComponent ();
            Service = new MockupSearchService();
            SearchGroupList=new ObservableCollection<SearchGroup>() { new SearchGroup(Service.SearchGroupList) };
            this.Searchlist.ItemsSource = SearchGroupList ;

        }

        
        private void Searchlist_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var search = e.SelectedItem as Search;
            DisplayAlert("Location",search.Location,"cancel");
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.SearchGroupList.Clear();
            this.SearchGroupList.Add(new SearchGroup(Service.GetSearches(e.NewTextValue)));

        }

        private void Searchlist_Refreshing(object sender, EventArgs e)
        {
            this.SearchGroupList.Clear();
            this.SearchGroupList.Add(new SearchGroup(Service.SearchGroupList));
        }

        private void MenuItem_Clicked(object sender, EventArgs e)
        {
            var Search = (sender as MenuItem).CommandParameter as Search;
             Service.DeleteSearch(Search.Id);
            Searchlist.EndRefresh();



        }
    }
}