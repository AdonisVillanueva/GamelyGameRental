namespace Gamely.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GameTableModified : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Games", "Genre", c => c.String());
            AddColumn("dbo.Games", "DateAdded", c => c.DateTime());
            AddColumn("dbo.Games", "ReleaseDate", c => c.DateTime());
            AddColumn("dbo.Games", "Stock", c => c.Int(nullable: false));
            AlterColumn("dbo.Games", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Games", "Name", c => c.String());
            DropColumn("dbo.Games", "Stock");
            DropColumn("dbo.Games", "ReleaseDate");
            DropColumn("dbo.Games", "DateAdded");
            DropColumn("dbo.Games", "Genre");
        }
    }
}
