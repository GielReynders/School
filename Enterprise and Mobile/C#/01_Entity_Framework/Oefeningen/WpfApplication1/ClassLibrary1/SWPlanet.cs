using Newtonsoft.Json;
using System;
using System.Collections.Generic;
namespace StarWarsUniverse.Model
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
        public string SurfaceWater { get; set; }
        public string Population { get; set; }
        [JsonIgnore]
        public virtual List<SWMovie> Films { get; set; }
        [JsonProperty(PropertyName = "films")]
        public List<string> FilmUris { get; set; }
    }
}