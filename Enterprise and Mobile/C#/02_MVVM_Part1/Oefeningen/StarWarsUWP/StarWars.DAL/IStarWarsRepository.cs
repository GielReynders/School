using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarWars.Domain.Classes;


namespace StarWars.DAL
{
    public interface IStarWarsRepository
    {
         SWMovie GetMovieByUrl(string url);
    }
}
