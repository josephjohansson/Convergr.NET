namespace Convergr.NET.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateUniList2 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Hashtags", newName: "HashtagModels");
            RenameTable(name: "dbo.YouTubeVideos", newName: "YouTubeVideoModels");
            CreateTable(
                "dbo.UniversityModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.HashtagModels", "YouTubeVideoModels_Id", c => c.Int());
            CreateIndex("dbo.HashtagModels", "YouTubeVideoModels_Id");
            AddForeignKey("dbo.HashtagModels", "YouTubeVideoModels_Id", "dbo.YouTubeVideoModels", "Id");
            DropTable("dbo.Universities");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Universities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropForeignKey("dbo.HashtagModels", "YouTubeVideoModels_Id", "dbo.YouTubeVideoModels");
            DropIndex("dbo.HashtagModels", new[] { "YouTubeVideoModels_Id" });
            DropColumn("dbo.HashtagModels", "YouTubeVideoModels_Id");
            DropTable("dbo.UniversityModels");
            RenameTable(name: "dbo.YouTubeVideoModels", newName: "YouTubeVideos");
            RenameTable(name: "dbo.HashtagModels", newName: "Hashtags");
        }
    }
}
