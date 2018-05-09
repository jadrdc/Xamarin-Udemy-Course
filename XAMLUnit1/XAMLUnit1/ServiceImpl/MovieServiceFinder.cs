using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using XAMLUnit1.Models;
using XAMLUnit1.Services;
using XAMLUnit1.Utils;

namespace XAMLUnit1.ServiceImpl
{
    public class MovieServiceFinder : IMovieService
    {
        HttpClient client;
        public ObservableCollection<Movie> ListMovie;
        public MovieServiceFinder()
        {
            client = new HttpClient();
        }

        private  void  GetMoviesTask(string param)
        {
            var resp = client.GetStringAsync(MovieServiceConfig.GET_CHANGE).Result;
            var ChangeList= JsonConvert.DeserializeObject<MovieResult>(resp);             var Movies = ChangeList.results.Take(5);
            
            ListMovie = new ObservableCollection<Movie>();
            
           foreach(MovieChange result in Movies)
            {
                resp=  client.GetStringAsync(MovieServiceConfig.GET_MOVIE + result.id + MovieServiceConfig.MOVIE_API_KEY).Result;
                var movie = JsonConvert.DeserializeObject<Movie>(resp);
                ListMovie.Add(movie);

            }

}

        public ObservableCollection<Movie> GetMovies(string param)
        {
          GetMoviesTask(param);
            return ListMovie;

        } 
    }
}
