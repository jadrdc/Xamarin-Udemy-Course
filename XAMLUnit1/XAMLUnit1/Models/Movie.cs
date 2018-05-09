using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XAMLUnit1.Models
{
    public class Movie
    {
        bool? adult { get; set; }
        public string backdrop_path { get; set; }
    [JsonProperty("belongs_to_collection")]
        public Collection belongs_to_collection { get; set; }
        public int budget { get; set; }
        [JsonProperty("genres")]
        public List<Genre> genres { get; set; }
        public string homepage { get; set; }
        public int id  { get; set; }
        public string imdb_id { get; set; }
        public string original_language { get; set; }
        public string original_title { get; set; }
        public string overview { get; set; }
        public double popularity { get; set; }
        public string poster_path { get; set; }
        [JsonProperty("production_companies")]
        public List<ProductionCompany> production_companies { get; set; }
        [JsonProperty("production_countries")]
        public List<ProductionCountry> production_countries { get; set; }
        public DateTime? release_date { get; set; }
        public long? revenue { get; set; }
        public long? runtime { get; set; }
        [JsonProperty("spoken_languages")]
        public List<Language> spoken_languages { get; set; }
        public string status { get; set; }
        public string tagline { get; set; }
        public string title { get; set; }
        bool? video { get; set; }
        public double? vote_average { get; set; }
        public double? vote_count { get; set; }

    }

    public class Genre
    {
        public int id { get; set; }
        public string name { get; set; }
    }


    public class ProductionCompany
    {
        public int id { get; set; }
        public string logo_path { get; set; }
        public string name { get; set; }
        public string origin_country { get; set; }

    }

    public class Collection
    {
        public int id { get; set; }
        public string name { get; set; }
        public string poster_path { get; set; }
        public string backdrop_path { get; set; }

    }
    public class ProductionCountry
    {
        public string iso_3166_1 { get; set; }
        public string name { get; set; }

    }
    public class Language
    {
        public string iso_639_1        { get; set; }
        public string name { get; set; }

    }
} 