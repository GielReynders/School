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
            List<SWPlanet> planets = swds.GetAllSWPlanets();
           
            
            movies.ForEach(s => context.SWMovie.AddOrUpdate(m => m.ResourceUri, s));
            context.SaveChanges();

            

            foreach(var p in planets)
            {
                context.SWPlanet.AddOrUpdate(m => m.ResourceUri, p);
                
                foreach (var f in p.Filmuris)
                {
                    var movie = context.SWMovie
                        .First((m) => m.ResourceUri == f);

                    //alle planeten laden van de movie movie
                    context.Entry(movie).Collection("Planets").Load();
                    movie.Planets.Add(p);
                    context.SaveChanges();

                    //alle films laden van planeet p
                    context.Entry(p).Collection("Films").Load();

                    p.Films.Add(movie);
                    context.SaveChanges();
                }
            }


            //foreach (var m in movies)
            //{
            //    foreach (var f in m.PlanetUris)
            //    {
            //        context.Entry(m).Collection(s => s.Planets).Load();
            //        m.Planets.Add(planets.Find(p => p.ResourceUri == f));
            //    }
            //}

            //Planets.ForEach(s => context.SWPlanet.AddOrUpdate(m => m.filmuris, s)); 


        }
    }
}
