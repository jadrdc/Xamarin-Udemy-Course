using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XAMLUnit1.Models
{
    public class SearchGroup : ObservableCollection<Search>
    {
        public  String Title { get { return "Recent Search"; } }
        public SearchGroup( IEnumerable<Search> searches = null)
           : base(searches)
        {
           
        }
    }
}
