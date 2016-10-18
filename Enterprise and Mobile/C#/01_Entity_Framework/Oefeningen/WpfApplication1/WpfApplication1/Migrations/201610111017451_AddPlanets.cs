namespace StarWarsUniverse.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPlanets : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SWMovies",
                c => new
                    {
                        ResourceUri = c.String(nullable: false, maxLength: 128),
                        Title = c.String(),
                        Episode_ID = c.Int(nullable: false),
                        OpeningCrawl = c.String(),
                        Director = c.String(),
                        Producer = c.String(),
                        ReleaseDate = c.DateTime(nullable: false),
                        Created = c.DateTime(nullable: false),
                        Edited = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ResourceUri);
            
            CreateTable(
                "dbo.SWPlanets",
                c => new
                    {
                        ResourceUri = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        RotationPeriod = c.Int(nullable: false),
                        OrbitalPeriod = c.Int(nullable: false),
                        Diameter = c.Int(nullable: false),
                        Climate = c.String(),
                        Gravity = c.String(),
                        Terrain = c.String(),
                        SurfaceWater = c.String(),
                        Population = c.String(),
                        Created = c.DateTime(nullable: false),
                        Edited = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ResourceUri);
            
            CreateTable(
                "dbo.SWPlanetSWMovies",
                c => new
                    {
                        SWPlanet_ResourceUri = c.String(nullable: false, maxLength: 128),
                        SWMovie_ResourceUri = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.SWPlanet_ResourceUri, t.SWMovie_ResourceUri })
                .ForeignKey("dbo.SWPlanets", t => t.SWPlanet_ResourceUri, cascadeDelete: true)
                .ForeignKey("dbo.SWMovies", t => t.SWMovie_ResourceUri, cascadeDelete: true)
                .Index(t => t.SWPlanet_ResourceUri)
                .Index(t => t.SWMovie_ResourceUri);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SWPlanetSWMovies", "SWMovie_ResourceUri", "dbo.SWMovies");
            DropForeignKey("dbo.SWPlanetSWMovies", "SWPlanet_ResourceUri", "dbo.SWPlanets");
            DropIndex("dbo.SWPlanetSWMovies", new[] { "SWMovie_ResourceUri" });
            DropIndex("dbo.SWPlanetSWMovies", new[] { "SWPlanet_ResourceUri" });
            DropTable("dbo.SWPlanetSWMovies");
            DropTable("dbo.SWPlanets");
            DropTable("dbo.SWMovies");
        }
    }
}
