using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarWars.Domain.Classes;
using System.Net.Http;
using Newtonsoft.Json;

namespace StarWars.DAL
{
    class SWAPIRepository : IStarWarsRepository
    {
        public SWMovie GetMovieByUrl(string url)
        {
            var client = new HttpClient();
            var response = Task.Run(() => client.GetAsync(url)).Result;
            response.EnsureSuccessStatusCode();
            var result = Task.Run(() => response.Content.ReadAsStringAsync()).Result;
            var movie = JsonConvert.DeserializeObject<SWMovie>(result);
            return movie;
        }
    }
}
