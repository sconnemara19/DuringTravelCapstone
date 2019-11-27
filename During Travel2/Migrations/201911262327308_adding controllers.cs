namespace During_Travel2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingcontrollers : DbMigration
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
                "dbo.Destinations",
                c => new
                    {
                        DestinationId = c.Int(nullable: false, identity: true),
                        destinationName = c.String(),
                    })
                .PrimaryKey(t => t.DestinationId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Destinations");
            DropTable("dbo.BookingAgencies");
        }
    }
}
