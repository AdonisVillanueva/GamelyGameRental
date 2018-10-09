namespace Gamely.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedGenre : DbMigration
    {
        public override void Up()
        {
			Sql("Insert into dbo.Genres (name) values ('Role-Playing')");
			Sql("Insert into dbo.Genres (name) values ('Action/Adventure')");
			Sql("Insert into dbo.Genres (name) values ('Sports')");
			Sql("Insert into dbo.Genres (name) values ('Puzzle')");
			Sql("Insert into dbo.Genres (name) values ('Fighting')");
			Sql("Insert into dbo.Genres (name) values ('Shooter')");
			Sql("Insert into dbo.Genres (name) values ('Simulation')");
			Sql("Insert into dbo.Genres (name) values ('Stealth')");
			Sql("Insert into dbo.Genres (name) values ('Survival/Horror')");
			Sql("Insert into dbo.Genres (name) values ('Rythm')");

		}
        
        public override void Down()
        {
        }
    }
}
