using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XAMLUnit1.Utils
{
    public static class MovieServiceConfig
    { 
      public static  String MOVIE_API_KEY= "?api_key=2ffd7fdfdb1c359bc87bfdf6f209f997";
        public static String GET_CHANGE = "https://api.themoviedb.org/3/movie/changes"+MOVIE_API_KEY;
        public static String GET_MOVIE = "https://api.themoviedb.org/3/movie/";


    }
}
