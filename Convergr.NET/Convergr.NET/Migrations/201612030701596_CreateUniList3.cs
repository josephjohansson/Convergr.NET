namespace Convergr.NET.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateUniList3 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.HashtagModels", name: "YouTubeVideoModels_Id", newName: "Type_Id");
            RenameIndex(table: "dbo.HashtagModels", name: "IX_YouTubeVideoModels_Id", newName: "IX_Type_Id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.HashtagModels", name: "IX_Type_Id", newName: "IX_YouTubeVideoModels_Id");
            RenameColumn(table: "dbo.HashtagModels", name: "Type_Id", newName: "YouTubeVideoModels_Id");
        }
    }
}
