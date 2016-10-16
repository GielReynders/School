using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsMovies.DomainClasses.Classes
{
    public class SWMovie : SWResource
    {
        public string Title { get; set; }

        public int Episode_ID { get; set; }

        [JsonProperty(PropertyName = "opening_crawl")]
        public string OpeningCrawl { get; set; }

        public string Director { get; set; }

        public string Producer { get; set; }

        [JsonProperty(PropertyName = "release_date")]
        public DateTime ReleaseDate { get; set; }

        [JsonIgnore]
        public virtual List<SWPlanet> Planets { get; set; }

        [JsonProperty(PropertyName = "planets")]
        public List<string> PlanetUris { get; set; }
    }
}
