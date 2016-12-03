namespace Convergr.NET.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateHashtags : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Hashtags (Name) VALUES ('Joe')");
            Sql("INSERT INTO Hashtags (Name) VALUES ('Rogan')");
          
            
        }
        
        public override void Down()
        {
        }
    }
}
