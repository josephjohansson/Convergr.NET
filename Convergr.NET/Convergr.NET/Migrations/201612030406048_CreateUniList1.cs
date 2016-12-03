namespace Convergr.NET.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateUniList1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.YouTubeVideos", "VideoID", c => c.String());
            AddColumn("dbo.YouTubeVideos", "Score", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.YouTubeVideos", "Score");
            DropColumn("dbo.YouTubeVideos", "VideoID");
        }
    }
}
