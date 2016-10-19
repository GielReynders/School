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
        public int Diameter { get; set; }
        public string Climate { get; set; }
        public string Gravity { get; set; }
        public string Terrain { get; set; }
        [JsonProperty("surface_water")]
        public string Surfacewater { get; set; }
        public string Population { get; set; }
        [JsonIgnore]
        public virtual List<SWMovie> Films { get; set; }
        [JsonProperty(PropertyName = "films")]
        public List<string> Filmuris { get; set; }
    }
}
