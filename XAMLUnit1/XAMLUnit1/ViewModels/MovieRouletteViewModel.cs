using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using XAMLUnit1.Models;
using XAMLUnit1.ServiceImpl;
using XAMLUnit1.Services;
using XAMLUnit1.Views;

namespace XAMLUnit1.ViewModels
{
  public  class MovieRouletteViewModel
    {
        public string title { get; set; }

        IMovieService service;
        public ObservableCollection<Movie> MovieList { get; set; }
        public ICommand SearchMovieCommand { get; set; }
        public ICommand SeeMovieDetail { get; set; }
        private IPageService pageService;
        public MovieRouletteViewModel()
        {
        }

        public MovieRouletteViewModel(IPageService page)
        {
            pageService = page;
                  service = new MovieServiceFinder();
            SearchMovieCommand = new Command(GetMovies);
            SeeMovieDetail = new Command<Movie>( mov => SeeMovieDetails(mov));
            MovieList = new ObservableCollection<Movie>();
        }

        private void  GetMovies()
        {
            var list= service.GetMovies("");
            MovieList.Clear();
            foreach (Movie mov in list)
            {
                MovieList.Add(mov);
            }

        }

        private void SeeMovieDetails(Movie movie)
        {

            pageService.PushAsync(new MovieDetailPage(movie));
        }

    }
}
