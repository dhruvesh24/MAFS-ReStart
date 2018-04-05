namespace MAFS_ReStart.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class YouTubeLink : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Fundraisers", "YouTubeLink", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Fundraisers", "YouTubeLink");
        }
    }
}
