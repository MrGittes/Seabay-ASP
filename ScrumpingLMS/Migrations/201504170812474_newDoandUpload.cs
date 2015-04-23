namespace ScrumpingLMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newDoandUpload : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Dokuments", "DokumentName", c => c.String());
            DropColumn("dbo.Dokuments", "DokumentObjekt");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Dokuments", "DokumentObjekt", c => c.Binary());
            DropColumn("dbo.Dokuments", "DokumentName");
        }
    }
}
