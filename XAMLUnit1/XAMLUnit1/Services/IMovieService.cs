using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XAMLUnit1.Models;

namespace XAMLUnit1.Services
{
    interface IMovieService
    {

        ObservableCollection< Movie> GetMovies(string param);
    }
}
