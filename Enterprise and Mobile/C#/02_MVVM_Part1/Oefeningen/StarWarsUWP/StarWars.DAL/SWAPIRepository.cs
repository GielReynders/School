using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarWars.Domain.Classes;
using Newtonsoft.Json;

namespace StarWars.DAL
{
    public class SWAPIRepository : IStarWarsRepository
    {
        public SWMovie GetMovieByUrl(string url)
        {
            SWMovie movie = JsonConvert.DeserializeObject<SWMovie>(url);
            return movie;
        }
    }
}
