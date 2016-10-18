namespace StarWarsUniverse.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<datalayer.StarWarsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(datalayer.StarWarsContext context)
        {
            Services.SWDataService swds = new Services.SWDataService();
            List<Model.SWMovie> swmvs = swds.GetAllSWMovies();
            List<Model.SWPlanet> swpns = swds.GetAllSWPlanets();
            swmvs.ForEach(s => context.movies.AddOrUpdate(m => m.ResourceUri, s));
            swpns.ForEach(s => context.planets.AddOrUpdate(m => m.ResourceUri, s));
            foreach (var p in swpns)
            {
                context.Entry(p).Collection(s => s.Films).Load();
                foreach (var f in p.FilmUris)
                {
                    p.Films.Add(swmvs.Find(m => m.ResourceUri == f));
                }
            };
            context.SaveChanges();
            foreach (var p in swmvs)
            {
                context.Entry(p).Collection(s => s.Planets).Load();
                foreach (var f in p.PlanetUris)
                {
                    p.Planets.Add(swpns.Find(m => m.ResourceUri == f));
                }
            };
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
        }
    }
}
