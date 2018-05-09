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
using XAMLUnit1.ViewModels;

namespace XAMLUnit1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NetflixRoulettePage : ContentPage
    {
        MovieRouletteViewModel viewModel;
        public NetflixRoulettePage()
        {
            InitializeComponent();
            viewModel = new MovieRouletteViewModel(new PageServiceImp());
            BindingContext = viewModel;
      
                
        }

        private void ListOfMovies_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            viewModel.SeeMovieDetail.Execute(e.SelectedItem as Movie);

        }
    }
}