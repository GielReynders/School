using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsUniverse
{
    class Program
    {
        public static void main(string[] args)
        {
            Services.SWDataService sds = new Services.SWDataService();
            List<Model.SWMovie> movies = sds.GetAllSWMovies();
            Console.Out.WriteLine("=== Star Wars Movies ===");
            for(int i = 0; i < movies.Count; i++)
            {
                Console.Out.WriteLine(movies[i].Title);
                Console.Out.WriteLine("     Released: " + movies[i].ReleaseDate);
            }
            Console.Out.WriteLine("========================");
        }
    }
}
