namespace During_Travel2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class secondmigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clients", "Confirmation", c => c.String());
            DropColumn("dbo.Clients", "PickupTime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Clients", "PickupTime", c => c.String());
            DropColumn("dbo.Clients", "Confirmation");
        }
    }
}
