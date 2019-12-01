namespace During_Travel2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class vacationid1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Vacations",
                c => new
                    {
                        VacationId = c.Int(nullable: false, identity: true),
                        ClientId = c.Int(nullable: false),
                        TraveldocsId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.VacationId)
                .ForeignKey("dbo.Clients", t => t.ClientId, cascadeDelete: true)
                .ForeignKey("dbo.TravelDocs", t => t.TraveldocsId, cascadeDelete: true)
                .Index(t => t.ClientId)
                .Index(t => t.TraveldocsId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vacations", "TraveldocsId", "dbo.TravelDocs");
            DropForeignKey("dbo.Vacations", "ClientId", "dbo.Clients");
            DropIndex("dbo.Vacations", new[] { "TraveldocsId" });
            DropIndex("dbo.Vacations", new[] { "ClientId" });
            DropTable("dbo.Vacations");
        }
    }
}
