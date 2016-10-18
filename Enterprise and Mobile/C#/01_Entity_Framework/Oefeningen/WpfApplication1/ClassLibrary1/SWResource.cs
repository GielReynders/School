using Newtonsoft.Json;
using System;

namespace StarWarsUniverse.Model
{
    public abstract class SWResource
    {
        public DateTime Created { get; set; }
        public DateTime Edited { get; set; }
        [JsonProperty(PropertyName = "url")]
        public string ResourceUri { get; set; }
    }
}