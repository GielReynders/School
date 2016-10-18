using StarWarsUniverse.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsUniverse.datalayer
{
    public class StarWarsContext : DbContext
    {
        public StarWarsContext() : base("StarWarsDB")
        {

        }
        public DbSet<SWMovie> movies { get; set; }
        public DbSet<SWPlanet> planets { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SWMovie>().HasKey(c => c.ResourceUri);
            modelBuilder.Entity<SWPlanet>().HasKey(c => c.ResourceUri);
            base.OnModelCreating(modelBuilder);
        }
    }
}
