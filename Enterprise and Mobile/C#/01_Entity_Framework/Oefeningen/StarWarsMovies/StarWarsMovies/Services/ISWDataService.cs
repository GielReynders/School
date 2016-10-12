using StarWarsMovies.DomainClasses.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsMovies.Services
{
    interface ISWDataService
    {
        List<SWMovie> GetAllSWMovies();
        SWMovie GetSWMovieDetails(string uri);
    }
}
