using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsMovies.DomainClasses.Classes
{
    public abstract class SWResource
    {
        public DateTime Created { get; set; }
        public DateTime Edited { get; set; }

        [Key]
        [JsonProperty(PropertyName = "url")]
        public string ResourceUri { get; set; }
    }
}
