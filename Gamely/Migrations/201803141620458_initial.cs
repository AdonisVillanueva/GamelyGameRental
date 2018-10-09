namespace Gamely.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
		public override void Up()
		{
			AddColumn("dbo.Games", "NumberInStock", c => c.Byte(nullable: false));
			AddColumn("dbo.Games", "NumberAvailable", c => c.Byte(nullable: false));
			AlterColumn("dbo.Games", "Name", c => c.String(nullable: false, maxLength: 255));

		}
        public override void Down()
        {
           
            AlterColumn("dbo.Games", "Name", c => c.String(nullable: false));
            DropColumn("dbo.Games", "NumberAvailable");
            DropColumn("dbo.Games", "NumberInStock");
        }
    }
}
