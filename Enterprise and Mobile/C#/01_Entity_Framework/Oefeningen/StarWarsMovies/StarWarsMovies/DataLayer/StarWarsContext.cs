using StarWarsMovies.DomainClasses.Classes;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsMovies.DataLayer
{
    public class StarWarsContext : DbContext
    {
        public StarWarsContext() : base("StarWarsDB")
            {}

        public DbSet<SWMovie> SWMovie { get; set; }
        public DbSet<SWPlanet> SWPlanet { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SWMovie>().HasKey(c => c.ResourceUri).HasMany(s => s.Planets);



            modelBuilder.Entity<SWPlanet>().HasKey(c => c.ResourceUri).HasMany(s => s.films);



            //modelBuilder.Entity<SWMovie>()
            //    .HasMany<SWPlanet>(c => c.Planets)
            //    .WithMany(d => d.films)
            //    .Map(cs =>
            //        {
            //            cs.MapLeftKey("ResourceUri");
            //            cs.MapRightKey("ResourceUri");
            //            cs.ToTable("SWMovieSWPlanet");
            //        }

            //    );

            //t => t.MapLeftKey("ResourceUri")
            //.MapRightKey("ResourceUri")
            //.ToTable("SWMovieSWPlanets"));
        }
    }
}
