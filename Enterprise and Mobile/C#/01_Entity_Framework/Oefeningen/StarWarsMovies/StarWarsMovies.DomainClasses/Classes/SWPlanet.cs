using Newtonsoft.Json;
using StarWarsMovies.DomainClasses.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsMovies.DomainClasses.Classes
{
    public class SWPlanet : SWResource
    {
        public string Name { get; set; }
        [JsonProperty("rotation_period")]
        public int RotationPeriod { get; set; }
        [JsonProperty("orbital_period")]
        public int OrbitalPeriod { get; set; }
        public int diameter { get; set; }
        public string climate { get; set; }
        public string gravity { get; set; }
        public string terrain { get; set; }
        [JsonProperty("surface_water")]
        public string surfacewater { get; set; }
        public string population { get; set; }
        [JsonIgnore]
        public virtual List<SWMovie> films { get; set; }
        [JsonProperty(PropertyName = "films")]
        public List<string> filmuris { get; set; }
    }
}
