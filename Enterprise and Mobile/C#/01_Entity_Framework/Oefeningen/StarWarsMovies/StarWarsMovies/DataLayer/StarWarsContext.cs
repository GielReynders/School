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
            modelBuilder.Entity<SWMovie>().HasKey(c => c.ResourceUri);
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<SWPlanet>().HasKey(c => c.filmuris);

            modelBuilder.Entity<SWPlanet>().HasMany(s => s.films);

            modelBuilder.Entity<SWMovie>().HasMany(s => s.Planets);
        }
    }
}
