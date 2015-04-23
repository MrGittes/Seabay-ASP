namespace ScrumpingLMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Dokname : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ScheduleDayUploads", "DokumentName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ScheduleDayUploads", "DokumentName");
        }
    }
}
