namespace DuringTravelAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class intial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BookingAgencies",
                c => new
                    {
                        BookingAgencyId = c.Int(nullable: false, identity: true),
                        bookingAgencyName = c.String(),
                    })
                .PrimaryKey(t => t.BookingAgencyId);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        ClientId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ClientId);
            
            CreateTable(
                "dbo.Destinations",
                c => new
                    {
                        DestinationId = c.Int(nullable: false, identity: true),
                        destinationName = c.String(),
                    })
                .PrimaryKey(t => t.DestinationId);
            
            CreateTable(
                "dbo.TravelDocs",
                c => new
                    {
                        TraveldocsId = c.Int(nullable: false, identity: true),
                        Hotel = c.String(),
                        RoomCategory = c.String(),
                        Stay = c.Int(nullable: false),
                        nameOfRep = c.String(),
                        repHoursAtHotel = c.String(),
                        DateOfArrival = c.DateTime(),
                        DateOfDeparture = c.DateTime(),
                        returnFlightInfo = c.String(),
                        Confirmation = c.String(),
                        TimeofPickUp = c.String(),
                    })
                .PrimaryKey(t => t.TraveldocsId);
            
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
            DropTable("dbo.TravelDocs");
            DropTable("dbo.Destinations");
            DropTable("dbo.Clients");
            DropTable("dbo.BookingAgencies");
        }
    }
}
