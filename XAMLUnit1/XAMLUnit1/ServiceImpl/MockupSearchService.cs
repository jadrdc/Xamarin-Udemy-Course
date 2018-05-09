using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XAMLUnit1.Models;
using XAMLUnit1.Services;

namespace XAMLUnit1.ServiceImpl
{
    public class MockupSearchService : ISearchService
    {
        public ObservableCollection<Search> SearchGroupList { get; set; }

        public MockupSearchService()
        {
            SearchGroupList = new ObservableCollection<Search>()
            
            { new Search(){ Id=1, Checkin=DateTime.Now, Checkout=DateTime.Now, Location="La Cienega" },
            new Search(){ Id=2, Checkin=DateTime.Now, Checkout=DateTime.Now, Location="Pico Duarte" },
            new Search(){ Id=3, Checkin=DateTime.Now, Checkout=DateTime.Now, Location="La Comparticion" },
            new Search(){ Id=4, Checkin=DateTime.Now, Checkout=DateTime.Now, Location="Las Cuevas De Las Maravillas" }
            ,new Search() { Id = 5, Checkin = DateTime.Now, Checkout = DateTime.Now, Location = "Bayahibe" }
        
            };
          
        }
        public void DeleteSearch(int searchId)
        {
            var Search = SearchGroupList.Where(x=>x.Id==searchId);
             SearchGroupList.Remove(Search.First());
        }

        public IEnumerable<Search> GetSearches(string filter = null)
        {

            return SearchGroupList.Where(x=>x.Location.ToLower().Contains(filter.ToLower())) ;
        }
    }
}
