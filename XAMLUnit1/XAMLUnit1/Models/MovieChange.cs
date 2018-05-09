using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XAMLUnit1.Models
{


    public class MovieResult
    {
        [JsonProperty("results")]
        public List<MovieChange> results { get; set; }
        public int page { get; set; }
        public int total_pages { get; set; }
        public int total_results { get; set; }
    }


    public class MovieChange
    {
        public int id { get; set; }
        public bool?  adult { get; set; }

    }


}
