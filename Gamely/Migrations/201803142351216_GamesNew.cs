namespace Gamely.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GamesNew : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Games", "GenreId", c => c.Byte(nullable: false));
            AddColumn("dbo.Games", "DateAdded", c => c.DateTime());
            AddColumn("dbo.Games", "ReleaseDate", c => c.DateTime());
            AddColumn("dbo.Games", "Genre_Id", c => c.Int());
            CreateIndex("dbo.Games", "Genre_Id");
            AddForeignKey("dbo.Games", "Genre_Id", "dbo.Genres", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Games", "Genre_Id", "dbo.Genres");
            DropIndex("dbo.Games", new[] { "Genre_Id" });
            DropColumn("dbo.Games", "Genre_Id");
            DropColumn("dbo.Games", "ReleaseDate");
            DropColumn("dbo.Games", "DateAdded");
            DropColumn("dbo.Games", "GenreId");
            DropTable("dbo.Genres");
        }
    }
}
