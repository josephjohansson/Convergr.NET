namespace Convergr.NET.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateYT : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Hashtags (Name) VALUES ('Milo')");
            Sql("INSERT INTO Hashtags (Name) VALUES ('Yiannopoulos')");
            Sql("INSERT INTO YouTubeVideos (VideoTitle) VALUES ('LnH67G7vAu4')");
        }
        
        public override void Down()
        {
        }
    }
}
