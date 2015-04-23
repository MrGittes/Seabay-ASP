namespace ScrumpingLMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class generalaupdate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ScheduleDayUploads",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DayNumber = c.Int(nullable: false),
                        KlassId = c.Int(nullable: false),
                        LinkToDokument = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Klasses", t => t.KlassId, cascadeDelete: true)
                .Index(t => t.KlassId);
            
            AddColumn("dbo.Dokuments", "DokumentLink", c => c.String());
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ScheduleDayUploads", "KlassId", "dbo.Klasses");
            DropIndex("dbo.ScheduleDayUploads", new[] { "KlassId" });
            DropColumn("dbo.Dokuments", "DokumentLink");
            DropTable("dbo.ScheduleDayUploads");
        }
    }
}
