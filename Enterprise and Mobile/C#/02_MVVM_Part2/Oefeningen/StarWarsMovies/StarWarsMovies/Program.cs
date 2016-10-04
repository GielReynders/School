using StarWarsMovies.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsMovies
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new StarWarsContext())
            {

                Console.WriteLine("We beginnen");


                var query = from b in db.SWMovie
                            orderby b.Title
                            select b;

                foreach ( var item in query)
                {
                    Console.WriteLine("Epidsode: " + item.Episode_ID + " - " );
                }
            }
        }
    }
}
