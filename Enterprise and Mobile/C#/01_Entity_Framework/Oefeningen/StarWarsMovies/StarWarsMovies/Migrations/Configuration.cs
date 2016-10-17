namespace StarWarsMovies.Migrations
{
    using DomainClasses.Classes;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<StarWarsMovies.DataLayer.StarWarsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(StarWarsMovies.DataLayer.StarWarsContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            StarWarsMovies.Services.SWDataService swds = new StarWarsMovies.Services.SWDataService();
            List<SWMovie> movies = swds.GetAllSWMovies();
            List<SWPlanet> Planets = swds.GetAllSWPlanets();
            foreach (var movie in movies)
            {
                

                
            }
            
            movies.ForEach(s => context.SWMovie.AddOrUpdate(m => m.ResourceUri, s));

            
            Planets.ForEach(s => context.SWPlanet.AddOrUpdate(m => m.ResourceUri, s));

            

            //movies.ForEach(s => context.SWMovie.AddOrUpdate(m => m.PlanetUris, s));
            //Planets.ForEach(s => context.SWPlanet.AddOrUpdate(m => m.filmuris, s)); 
            
            
        }
    }
}
