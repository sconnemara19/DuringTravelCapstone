namespace During_Travel2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class morecontrollers : DbMigration
    {
        public override void Up()
        {
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
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TravelDocs");
        }
    }
}
