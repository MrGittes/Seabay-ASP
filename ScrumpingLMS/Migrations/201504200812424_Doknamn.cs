namespace ScrumpingLMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Doknamn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ScheduleDayUploads", "Dokumentnamn", c => c.String());
            DropColumn("dbo.ScheduleDayUploads", "DokumentName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ScheduleDayUploads", "DokumentName", c => c.String());
            DropColumn("dbo.ScheduleDayUploads", "Dokumentnamn");
        }
    }
}
